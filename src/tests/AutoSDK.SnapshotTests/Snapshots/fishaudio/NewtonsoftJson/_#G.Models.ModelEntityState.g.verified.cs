//HintName: G.Models.ModelEntityState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelEntityState
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
    public static class ModelEntityStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelEntityState value)
        {
            return value switch
            {
                ModelEntityState.Created => "created",
                ModelEntityState.Failed => "failed",
                ModelEntityState.Trained => "trained",
                ModelEntityState.Training => "training",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelEntityState? ToEnum(string value)
        {
            return value switch
            {
                "created" => ModelEntityState.Created,
                "failed" => ModelEntityState.Failed,
                "trained" => ModelEntityState.Trained,
                "training" => ModelEntityState.Training,
                _ => null,
            };
        }
    }
}