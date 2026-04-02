//HintName: G.Models.Response.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"id":"resp_67ccd3a9da748190baa7f1570fe91ac604becb25c45c1d41","object":"response","created_at":1741476777,"status":"completed","error":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","incomplete_details":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","instructions":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","max_output_tokens":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","model":"gpt-4o-2024-08-06","output":[{"type":"message","id":"msg_67ccd3acc8d48190a77525dc6de64b4104becb25c45c1d41","status":"completed","role":"assistant","content":[{"type":"output_text","text":"The image depicts a scenic landscape with a wooden boardwalk or pathway leading through lush, green grass under a blue sky with some clouds. The setting suggests a peaceful natural area, possibly a park or nature reserve. There are trees and shrubs in the background.","annotations":[]}]}],"parallel_tool_calls":true,"previous_response_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","reasoning":{"effort":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","summary":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"},"store":true,"temperature":1,"text":{"format":{"type":"text"}},"tool_choice":"auto","tools":[],"top_p":1,"truncation":"disabled","usage":{"input_tokens":328,"input_tokens_details":{"cached_tokens":0},"output_tokens":52,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":380},"user":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","metadata":{}}
    /// </summary>
    public readonly partial struct Response : global::System.IEquatable<Response>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelResponseProperties? ModelProperties { get; init; }
#else
        public global::G.ModelResponseProperties? ModelProperties { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelProperties))]
#endif
        public bool IsModelProperties => ModelProperties != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseProperties? Properties { get; init; }
#else
        public global::G.ResponseProperties? Properties { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Properties))]
#endif
        public bool IsProperties => Properties != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseVariant3? ResponseVariant3 { get; init; }
#else
        public global::G.ResponseVariant3? ResponseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseVariant3))]
#endif
        public bool IsResponseVariant3 => ResponseVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::G.ModelResponseProperties value) => new Response((global::G.ModelResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelResponseProperties?(Response @this) => @this.ModelProperties;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::G.ModelResponseProperties? value)
        {
            ModelProperties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::G.ResponseProperties value) => new Response((global::G.ResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseProperties?(Response @this) => @this.Properties;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::G.ResponseProperties? value)
        {
            Properties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::G.ResponseVariant3 value) => new Response((global::G.ResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseVariant3?(Response @this) => @this.ResponseVariant3;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::G.ResponseVariant3? value)
        {
            ResponseVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Response(
            global::G.ModelResponseProperties? modelProperties,
            global::G.ResponseProperties? properties,
            global::G.ResponseVariant3? responseVariant3
            )
        {
            ModelProperties = modelProperties;
            Properties = properties;
            ResponseVariant3 = responseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponseVariant3 as object ??
            Properties as object ??
            ModelProperties as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModelProperties?.ToString() ??
            Properties?.ToString() ??
            ResponseVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModelProperties && IsProperties && IsResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ModelResponseProperties?, TResult>? modelProperties = null,
            global::System.Func<global::G.ResponseProperties?, TResult>? properties = null,
            global::System.Func<global::G.ResponseVariant3?, TResult>? responseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelProperties && modelProperties != null)
            {
                return modelProperties(ModelProperties!);
            }
            else if (IsProperties && properties != null)
            {
                return properties(Properties!);
            }
            else if (IsResponseVariant3 && responseVariant3 != null)
            {
                return responseVariant3(ResponseVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ModelResponseProperties?>? modelProperties = null,
            global::System.Action<global::G.ResponseProperties?>? properties = null,
            global::System.Action<global::G.ResponseVariant3?>? responseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelProperties)
            {
                modelProperties?.Invoke(ModelProperties!);
            }
            else if (IsProperties)
            {
                properties?.Invoke(Properties!);
            }
            else if (IsResponseVariant3)
            {
                responseVariant3?.Invoke(ResponseVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelProperties,
                typeof(global::G.ModelResponseProperties),
                Properties,
                typeof(global::G.ResponseProperties),
                ResponseVariant3,
                typeof(global::G.ResponseVariant3),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Response other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ModelResponseProperties?>.Default.Equals(ModelProperties, other.ModelProperties) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseProperties?>.Default.Equals(Properties, other.Properties) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseVariant3?>.Default.Equals(ResponseVariant3, other.ResponseVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Response obj1, Response obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Response>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Response obj1, Response obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Response o && Equals(o);
        }
    }
}
