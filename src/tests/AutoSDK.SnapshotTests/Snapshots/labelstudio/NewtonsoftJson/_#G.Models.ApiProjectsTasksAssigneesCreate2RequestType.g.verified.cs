//HintName: G.Models.ApiProjectsTasksAssigneesCreate2RequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Assignment type. Use AN for annotate or RE for review.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiProjectsTasksAssigneesCreate2RequestType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AN")]
        An,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RE")]
        Re,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiProjectsTasksAssigneesCreate2RequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectsTasksAssigneesCreate2RequestType value)
        {
            return value switch
            {
                ApiProjectsTasksAssigneesCreate2RequestType.An => "AN",
                ApiProjectsTasksAssigneesCreate2RequestType.Re => "RE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectsTasksAssigneesCreate2RequestType? ToEnum(string value)
        {
            return value switch
            {
                "AN" => ApiProjectsTasksAssigneesCreate2RequestType.An,
                "RE" => ApiProjectsTasksAssigneesCreate2RequestType.Re,
                _ => null,
            };
        }
    }
}