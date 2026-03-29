//HintName: G.Models.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: cached
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cached")]
        Cached,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ttl")]
        Ttl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy value)
        {
            return value switch
            {
                ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy.Cached => "cached",
                ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy.Ttl => "ttl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy? ToEnum(string value)
        {
            return value switch
            {
                "cached" => ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy.Cached,
                "ttl" => ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicy.Ttl,
                _ => null,
            };
        }
    }
}