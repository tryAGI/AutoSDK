//HintName: G.Models.ApplicationInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of input field determining its behavior and validation rules.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApplicationInputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dropdown")]
        Dropdown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="media")]
        Media,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplicationInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplicationInputType value)
        {
            return value switch
            {
                ApplicationInputType.Dropdown => "dropdown",
                ApplicationInputType.File => "file",
                ApplicationInputType.Media => "media",
                ApplicationInputType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplicationInputType? ToEnum(string value)
        {
            return value switch
            {
                "dropdown" => ApplicationInputType.Dropdown,
                "file" => ApplicationInputType.File,
                "media" => ApplicationInputType.Media,
                "text" => ApplicationInputType.Text,
                _ => null,
            };
        }
    }
}