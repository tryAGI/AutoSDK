//HintName: G.Models.CreateCompletionResponse._Choices._FinishReasonEnum.g.cs

#nullable enable

namespace G
{
    public sealed partial class CreateCompletionResponse
    {
        public sealed partial class _Choices
        {
            /// <summary>
            /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,
            /// `length` if the maximum number of tokens specified in the request was reached,
            /// or `content_filter` if content was omitted due to a flag from our content filters.
            /// </summary>
            [global::System.Runtime.Serialization.DataContract]
            public enum _FinishReasonEnum
            {
                /// <summary>
                /// 
                /// </summary>
                [global::System.Runtime.Serialization.EnumMember(Value="stop")]
                Stop,
                /// <summary>
                /// 
                /// </summary>
                [global::System.Runtime.Serialization.EnumMember(Value="length")]
                Length,
                /// <summary>
                /// 
                /// </summary>
                [global::System.Runtime.Serialization.EnumMember(Value="content_filter")]
                ContentFilter,
            }
        }
    }
}