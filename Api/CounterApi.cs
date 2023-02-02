using System.ComponentModel.DataAnnotations;

namespace FluxorSample.Api;

public class CounterApi
{


    private int _counter;

    public async Task<Result<int>> GetCounter()
    {
        await Task.Delay(200);
        return new Result<int>.Success(_counter);
    }


    public async Task<Result<int>> IncrementCounter(
        [Range(0.0, 1.0)] double successRate = 0.5
    )
    {

        await Task.Delay(600);
        var random = new Random();
        var isSuccessful = random.NextDouble() > (1.0 - successRate);
        if (isSuccessful)
        {
            _counter++;
            return new Result<int>.Success(_counter);
        }

        return new Result<int>.Error(
            "Tough luck, try again... if you dare."
        );
    }

    public async Task<Result<int>> DecrementCounter(
        [Range(0.0, 1.0)] double successRate = 0.5
    )
    {

        await Task.Delay(600);
        var random = new Random();
        var isSuccessful = random.NextDouble() > successRate;
        if (isSuccessful)
        {
            _counter--;
            return new Result<int>.Success(_counter);
        }

        return new Result<int>.Error(
            "Tough luck, try again... if you dare."
        );
    }
}

public record Result<T>
{

    public record Success(
        T Data
    ) : Result<T>;

    public record Error(
        string Message
    ) : Result<T>;
}