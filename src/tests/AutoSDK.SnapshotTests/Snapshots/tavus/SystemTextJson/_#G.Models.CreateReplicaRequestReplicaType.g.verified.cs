//HintName: G.Models.CreateReplicaRequestReplicaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of replica.
    /// </summary>
    public enum CreateReplicaRequestReplicaType
    {
        /// <summary>
        /// 
        /// </summary>
        NonHuman,
        /// <summary>
        /// 
        /// </summary>
        Personal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateReplicaRequestReplicaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReplicaRequestReplicaType value)
        {
            return value switch
            {
                CreateReplicaRequestReplicaType.NonHuman => "non_human",
                CreateReplicaRequestReplicaType.Personal => "personal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReplicaRequestReplicaType? ToEnum(string value)
        {
            return value switch
            {
                "non_human" => CreateReplicaRequestReplicaType.NonHuman,
                "personal" => CreateReplicaRequestReplicaType.Personal,
                _ => null,
            };
        }
    }
}