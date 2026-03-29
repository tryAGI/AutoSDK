//HintName: G.Models.CreateReplicaRequestModelName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model to use (defaults to phoenix-4).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateReplicaRequestModelName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phoenix-3")]
        Phoenix3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phoenix-4")]
        Phoenix4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateReplicaRequestModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReplicaRequestModelName value)
        {
            return value switch
            {
                CreateReplicaRequestModelName.Phoenix3 => "phoenix-3",
                CreateReplicaRequestModelName.Phoenix4 => "phoenix-4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReplicaRequestModelName? ToEnum(string value)
        {
            return value switch
            {
                "phoenix-3" => CreateReplicaRequestModelName.Phoenix3,
                "phoenix-4" => CreateReplicaRequestModelName.Phoenix4,
                _ => null,
            };
        }
    }
}