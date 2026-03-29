//HintName: G.Models.OpenAPIToggleCollaborationModeRequestCollaborationMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAPIToggleCollaborationModeRequestCollaborationMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="collaboration")]
        Collaboration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="single")]
        Single,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAPIToggleCollaborationModeRequestCollaborationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAPIToggleCollaborationModeRequestCollaborationMode value)
        {
            return value switch
            {
                OpenAPIToggleCollaborationModeRequestCollaborationMode.Collaboration => "collaboration",
                OpenAPIToggleCollaborationModeRequestCollaborationMode.Single => "single",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAPIToggleCollaborationModeRequestCollaborationMode? ToEnum(string value)
        {
            return value switch
            {
                "collaboration" => OpenAPIToggleCollaborationModeRequestCollaborationMode.Collaboration,
                "single" => OpenAPIToggleCollaborationModeRequestCollaborationMode.Single,
                _ => null,
            };
        }
    }
}