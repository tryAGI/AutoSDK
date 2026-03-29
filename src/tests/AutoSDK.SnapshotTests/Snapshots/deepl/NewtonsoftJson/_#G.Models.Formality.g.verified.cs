//HintName: G.Models.Formality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sets whether the translated text should lean towards formal or informal language.<br/>
    /// This feature currently only works for target languages<br/>
    /// `DE` (German),<br/>
    /// `FR` (French),<br/>
    /// `IT` (Italian),<br/>
    /// `ES` (Spanish),<br/>
    /// `ES-419` (Latin American Spanish),<br/>
    /// `NL` (Dutch),<br/>
    /// `PL` (Polish),<br/>
    /// `PT-BR` and `PT-PT` (Portuguese),<br/>
    /// `JA` (Japanese),<br/>
    /// and `RU` (Russian).<br/>
    /// Learn more about the plain/polite feature for Japanese [here](https://support.deepl.com/hc/en-us/articles/6306700061852-About-the-plain-polite-feature-in-Japanese).<br/>
    /// Setting this parameter with a target language that does not support formality will fail,<br/>
    /// unless one of the `prefer_...` options are used.<br/>
    /// Possible options are:<br/>
    ///   * `default` (default)<br/>
    ///   * `more` - for a more formal language<br/>
    ///   * `less` - for a more informal language<br/>
    ///   * `prefer_more` - for a more formal language if available, otherwise fallback to default formality<br/>
    ///   * `prefer_less` - for a more informal language if available, otherwise fallback to default formality<br/>
    /// Default Value: default
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Formality
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="less")]
        Less,
        /// <summary>
        /// //support.deepl.com/hc/en-us/articles/6306700061852-About-the-plain-polite-feature-in-Japanese).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="more")]
        More,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prefer_less")]
        PreferLess,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prefer_more")]
        PreferMore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FormalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Formality value)
        {
            return value switch
            {
                Formality.Default => "default",
                Formality.Less => "less",
                Formality.More => "more",
                Formality.PreferLess => "prefer_less",
                Formality.PreferMore => "prefer_more",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Formality? ToEnum(string value)
        {
            return value switch
            {
                "default" => Formality.Default,
                "less" => Formality.Less,
                "more" => Formality.More,
                "prefer_less" => Formality.PreferLess,
                "prefer_more" => Formality.PreferMore,
                _ => null,
            };
        }
    }
}