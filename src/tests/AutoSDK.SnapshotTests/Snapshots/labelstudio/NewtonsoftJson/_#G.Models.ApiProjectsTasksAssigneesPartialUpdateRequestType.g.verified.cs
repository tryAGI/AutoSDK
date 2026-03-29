//HintName: G.Models.ApiProjectsTasksAssigneesPartialUpdateRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Assignment type. Use AN for annotate or RE for review.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiProjectsTasksAssigneesPartialUpdateRequestType
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
    public static class ApiProjectsTasksAssigneesPartialUpdateRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectsTasksAssigneesPartialUpdateRequestType value)
        {
            return value switch
            {
                ApiProjectsTasksAssigneesPartialUpdateRequestType.An => "AN",
                ApiProjectsTasksAssigneesPartialUpdateRequestType.Re => "RE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectsTasksAssigneesPartialUpdateRequestType? ToEnum(string value)
        {
            return value switch
            {
                "AN" => ApiProjectsTasksAssigneesPartialUpdateRequestType.An,
                "RE" => ApiProjectsTasksAssigneesPartialUpdateRequestType.Re,
                _ => null,
            };
        }
    }
}