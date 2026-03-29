//HintName: G.Models.WritingStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specify a style to rephrase your text in a way that fits your audience and goals.<br/>
    /// The `prefer_` prefix allows falling back to the default style if the language does not yet support styles.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WritingStyle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="academic")]
        Academic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="business")]
        Business,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="casual")]
        Casual,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prefer_academic")]
        PreferAcademic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prefer_business")]
        PreferBusiness,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prefer_casual")]
        PreferCasual,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prefer_simple")]
        PreferSimple,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="simple")]
        Simple,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WritingStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WritingStyle value)
        {
            return value switch
            {
                WritingStyle.Academic => "academic",
                WritingStyle.Business => "business",
                WritingStyle.Casual => "casual",
                WritingStyle.Default => "default",
                WritingStyle.PreferAcademic => "prefer_academic",
                WritingStyle.PreferBusiness => "prefer_business",
                WritingStyle.PreferCasual => "prefer_casual",
                WritingStyle.PreferSimple => "prefer_simple",
                WritingStyle.Simple => "simple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WritingStyle? ToEnum(string value)
        {
            return value switch
            {
                "academic" => WritingStyle.Academic,
                "business" => WritingStyle.Business,
                "casual" => WritingStyle.Casual,
                "default" => WritingStyle.Default,
                "prefer_academic" => WritingStyle.PreferAcademic,
                "prefer_business" => WritingStyle.PreferBusiness,
                "prefer_casual" => WritingStyle.PreferCasual,
                "prefer_simple" => WritingStyle.PreferSimple,
                "simple" => WritingStyle.Simple,
                _ => null,
            };
        }
    }
}