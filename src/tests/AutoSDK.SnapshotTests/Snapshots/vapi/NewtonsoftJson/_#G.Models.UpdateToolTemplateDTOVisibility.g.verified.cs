//HintName: G.Models.UpdateToolTemplateDTOVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: private
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateToolTemplateDTOVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateToolTemplateDTOVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateToolTemplateDTOVisibility value)
        {
            return value switch
            {
                UpdateToolTemplateDTOVisibility.Private => "private",
                UpdateToolTemplateDTOVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateToolTemplateDTOVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => UpdateToolTemplateDTOVisibility.Private,
                "public" => UpdateToolTemplateDTOVisibility.Public,
                _ => null,
            };
        }
    }
}