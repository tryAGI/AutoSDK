//HintName: G.Models.SampleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SampleType
    {
        /// <summary>
        /// 
        /// </summary>
        Pretrain,
        /// <summary>
        /// 
        /// </summary>
        Instruct,
        /// <summary>
        /// 
        /// </summary>
        BatchRequest,
        /// <summary>
        /// 
        /// </summary>
        BatchResult,
        /// <summary>
        /// 
        /// </summary>
        BatchError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SampleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SampleType value)
        {
            return value switch
            {
                SampleType.Pretrain => "pretrain",
                SampleType.Instruct => "instruct",
                SampleType.BatchRequest => "batch_request",
                SampleType.BatchResult => "batch_result",
                SampleType.BatchError => "batch_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SampleType? ToEnum(string value)
        {
            return value switch
            {
                "pretrain" => SampleType.Pretrain,
                "instruct" => SampleType.Instruct,
                "batch_request" => SampleType.BatchRequest,
                "batch_result" => SampleType.BatchResult,
                "batch_error" => SampleType.BatchError,
                _ => null,
            };
        }
    }
}