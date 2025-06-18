//HintName: G.Models.ContainerFileCitationBodyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the container file citation. Always `container_file_citation`.<br/>
    /// Default Value: container_file_citation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContainerFileCitationBodyType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="container_file_citation")]
        ContainerFileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerFileCitationBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerFileCitationBodyType value)
        {
            return value switch
            {
                ContainerFileCitationBodyType.ContainerFileCitation => "container_file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerFileCitationBodyType? ToEnum(string value)
        {
            return value switch
            {
                "container_file_citation" => ContainerFileCitationBodyType.ContainerFileCitation,
                _ => null,
            };
        }
    }
}