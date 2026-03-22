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
        BatchError,
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
        Instruct,
        /// <summary>
        /// 
        /// </summary>
        Pretrain,
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
                SampleType.BatchError => "batch_error",
                SampleType.BatchRequest => "batch_request",
                SampleType.BatchResult => "batch_result",
                SampleType.Instruct => "instruct",
                SampleType.Pretrain => "pretrain",
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
                "batch_error" => SampleType.BatchError,
                "batch_request" => SampleType.BatchRequest,
                "batch_result" => SampleType.BatchResult,
                "instruct" => SampleType.Instruct,
                "pretrain" => SampleType.Pretrain,
                _ => null,
            };
        }
    }
}