//HintName: G.Models.GetModelResponseState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelResponseState
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
    public static class GetModelResponseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelResponseState value)
        {
            return value switch
            {
                GetModelResponseState.Created => "created",
                GetModelResponseState.Failed => "failed",
                GetModelResponseState.Trained => "trained",
                GetModelResponseState.Training => "training",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelResponseState? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetModelResponseState.Created,
                "failed" => GetModelResponseState.Failed,
                "trained" => GetModelResponseState.Trained,
                "training" => GetModelResponseState.Training,
                _ => null,
            };
        }
    }
}