//HintName: G.Models.SplitSentencesOption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sets whether the translation engine should first split the input into sentences. For text translations where <br/>
    /// `tag_handling` is not set to `html`, the default value is `1`, meaning the engine splits on punctuation and on newlines.<br/>
    /// For text translations where `tag_handling=html`, the default value is `nonewlines`, meaning the engine splits on punctuation only, ignoring newlines.  <br/>
    /// The use of `nonewlines` as the default value for text translations where `tag_handling=html` is new behavior that was implemented in November 2022, <br/>
    /// when HTML handling was moved out of beta. <br/>
    /// Possible values are: <br/>
    ///  * `0` - no splitting at all, whole input is treated as one sentence<br/>
    ///  * `1` (default when `tag_handling` is not set to `html`) - splits on punctuation and on newlines<br/>
    ///  * `nonewlines` (default when `tag_handling=html`) - splits on punctuation only, ignoring newlines<br/>
    /// For applications that send one sentence per text parameter, we recommend setting `split_sentences` to `0`, in order to prevent the engine from splitting the sentence unintentionally.<br/>
    /// Please note that newlines will split sentences when `split_sentences=1`. We recommend cleaning files so they don't contain breaking sentences or setting the parameter `split_sentences` to `nonewlines`.<br/>
    /// Default Value: 1
    /// </summary>
    public enum SplitSentencesOption
    {
        /// <summary>
        /// 
        /// </summary>
        x0,
        /// <summary>
        /// 
        /// </summary>
        x1,
        /// <summary>
        /// 
        /// </summary>
        Nonewlines,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SplitSentencesOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SplitSentencesOption value)
        {
            return value switch
            {
                SplitSentencesOption.x0 => "0",
                SplitSentencesOption.x1 => "1",
                SplitSentencesOption.Nonewlines => "nonewlines",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SplitSentencesOption? ToEnum(string value)
        {
            return value switch
            {
                "0" => SplitSentencesOption.x0,
                "1" => SplitSentencesOption.x1,
                "nonewlines" => SplitSentencesOption.Nonewlines,
                _ => null,
            };
        }
    }
}