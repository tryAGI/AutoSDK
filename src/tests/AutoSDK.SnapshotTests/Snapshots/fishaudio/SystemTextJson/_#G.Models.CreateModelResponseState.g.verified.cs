//HintName: G.Models.CreateModelResponseState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelResponseState
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Trained,
        /// <summary>
        /// 
        /// </summary>
        Training,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelResponseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelResponseState value)
        {
            return value switch
            {
                CreateModelResponseState.Created => "created",
                CreateModelResponseState.Failed => "failed",
                CreateModelResponseState.Trained => "trained",
                CreateModelResponseState.Training => "training",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelResponseState? ToEnum(string value)
        {
            return value switch
            {
                "created" => CreateModelResponseState.Created,
                "failed" => CreateModelResponseState.Failed,
                "trained" => CreateModelResponseState.Trained,
                "training" => CreateModelResponseState.Training,
                _ => null,
            };
        }
    }
}