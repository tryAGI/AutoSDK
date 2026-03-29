//HintName: G.Models.PlaceholderMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: placeholder
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PlaceholderMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="placeholder")]
        Placeholder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaceholderMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaceholderMessageRole value)
        {
            return value switch
            {
                PlaceholderMessageRole.Placeholder => "placeholder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaceholderMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "placeholder" => PlaceholderMessageRole.Placeholder,
                _ => null,
            };
        }
    }
}