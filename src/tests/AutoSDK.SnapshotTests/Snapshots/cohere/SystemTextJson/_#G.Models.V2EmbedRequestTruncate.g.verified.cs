//HintName: G.Models.V2EmbedRequestTruncate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `NONE|START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
    /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
    /// If `NONE` is selected, when the input exceeds the maximum input token length an error will be returned.<br/>
    /// Default Value: END<br/>
    /// Included only in requests
    /// </summary>
    public enum V2EmbedRequestTruncate
    {
        /// <summary>
        /// 
        /// </summary>
        End,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Start,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2EmbedRequestTruncateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2EmbedRequestTruncate value)
        {
            return value switch
            {
                V2EmbedRequestTruncate.End => "END",
                V2EmbedRequestTruncate.None => "NONE",
                V2EmbedRequestTruncate.Start => "START",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2EmbedRequestTruncate? ToEnum(string value)
        {
            return value switch
            {
                "END" => V2EmbedRequestTruncate.End,
                "NONE" => V2EmbedRequestTruncate.None,
                "START" => V2EmbedRequestTruncate.Start,
                _ => null,
            };
        }
    }
}