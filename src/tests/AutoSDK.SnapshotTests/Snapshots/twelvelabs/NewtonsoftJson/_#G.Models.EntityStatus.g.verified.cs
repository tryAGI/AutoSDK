//HintName: G.Models.EntityStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the entity creation process.<br/>
    /// **Values**:<br/>
    /// - `processing`: The entity is being processed and is not yet ready for use in searches.<br/>
    /// - `ready`: The entity is fully processed and can be used in search queries.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EntityStatus
    {
        /// <summary>
        /// The entity is being processed and is not yet ready for use in searches.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
        /// <summary>
        /// The entity is being processed and is not yet ready for use in searches.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ready")]
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntityStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntityStatus value)
        {
            return value switch
            {
                EntityStatus.Processing => "processing",
                EntityStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntityStatus? ToEnum(string value)
        {
            return value switch
            {
                "processing" => EntityStatus.Processing,
                "ready" => EntityStatus.Ready,
                _ => null,
            };
        }
    }
}