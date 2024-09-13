#nullable enable

using System;

public class InvalidStateException : Exception
{
    private readonly GameState RequiredState;

    public InvalidStateException(string message, GameState requiredState)
        : base(message)
    {
        RequiredState = requiredState;
    }

    public InvalidStateException(string message, GameState requiredState, Exception innerException)
        : base(message, innerException)
    {
        RequiredState = requiredState;
    }

    public override string ToString()
    {
        var currentState = Game.GetInstance().GetState();
        return $"{Message}. Current state: ${currentState}. Required state: ${RequiredState}.";
    }
}
