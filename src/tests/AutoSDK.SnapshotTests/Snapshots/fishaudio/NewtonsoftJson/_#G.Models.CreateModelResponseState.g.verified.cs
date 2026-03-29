//HintName: G.Models.CreateModelResponseState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModelResponseState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trained")]
        Trained,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="training")]
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