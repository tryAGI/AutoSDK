//HintName: G.Models.TargetLanguageWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The language for the text improvement. Options currently available:<br/>
    ///  * `de` - German<br/>
    ///  * `en` - English (unspecified variant, defaults to `en-US`)<br/>
    ///  * `en-GB` - English (British)<br/>
    ///  * `en-US` - English (American)<br/>
    ///  * `es` - Spanish<br/>
    ///  * `fr` - French<br/>
    ///  * `it` - Italian<br/>
    ///  * `pt` - Portuguese (unspecified variant, defaults to `pt-PT`)<br/>
    ///  * `pt-BR` - Portuguese (Brazilian)<br/>
    ///  * `pt-PT` - Portuguese (all Portuguese variants excluding Brazilian Portuguese)<br/>
    /// Example: de
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TargetLanguageWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="de")]
        De,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en")]
        En,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-GB")]
        EnGb,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-US")]
        EnUs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fr")]
        Fr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="it")]
        It,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pt")]
        Pt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pt-BR")]
        PtBr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pt-PT")]
        PtPt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TargetLanguageWriteExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TargetLanguageWrite value)
        {
            return value switch
            {
                TargetLanguageWrite.De => "de",
                TargetLanguageWrite.En => "en",
                TargetLanguageWrite.EnGb => "en-GB",
                TargetLanguageWrite.EnUs => "en-US",
                TargetLanguageWrite.Fr => "fr",
                TargetLanguageWrite.It => "it",
                TargetLanguageWrite.Pt => "pt",
                TargetLanguageWrite.PtBr => "pt-BR",
                TargetLanguageWrite.PtPt => "pt-PT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TargetLanguageWrite? ToEnum(string value)
        {
            return value switch
            {
                "de" => TargetLanguageWrite.De,
                "en" => TargetLanguageWrite.En,
                "en-GB" => TargetLanguageWrite.EnGb,
                "en-US" => TargetLanguageWrite.EnUs,
                "fr" => TargetLanguageWrite.Fr,
                "it" => TargetLanguageWrite.It,
                "pt" => TargetLanguageWrite.Pt,
                "pt-BR" => TargetLanguageWrite.PtBr,
                "pt-PT" => TargetLanguageWrite.PtPt,
                _ => null,
            };
        }
    }
}