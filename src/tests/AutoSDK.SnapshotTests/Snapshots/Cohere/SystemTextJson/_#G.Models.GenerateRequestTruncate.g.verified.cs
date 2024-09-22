//HintName: G.Models.GenerateRequestTruncate.g.cs

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
    public enum GenerateRequestTruncate
    {
        /// <summary>
        /// 
        /// </summary>
        NONE,
        /// <summary>
        /// 
        /// </summary>
        START,
        /// <summary>
        /// 
        /// </summary>
        END,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateRequestTruncateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateRequestTruncate value)
        {
            return value switch
            {
                GenerateRequestTruncate.NONE => "NONE",
                GenerateRequestTruncate.START => "START",
                GenerateRequestTruncate.END => "END",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateRequestTruncate? ToEnum(string value)
        {
            return value switch
            {
                "NONE" => GenerateRequestTruncate.NONE,
                "START" => GenerateRequestTruncate.START,
                "END" => GenerateRequestTruncate.END,
                _ => null,
            };
        }
    }
}