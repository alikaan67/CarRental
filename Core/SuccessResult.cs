// Core/Utilities/Results/SuccessResult.cs
using Core.Utilities.Results;

public class SuccessResult : Result
{
    public SuccessResult(string message) : base(true, message) { }

    public SuccessResult() : base(true) { }
}
