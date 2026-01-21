//HintName: G.Models.LemurSummaryResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"request_id":"5e1b27c2-691f-4414-8bc5-f14678442f9e","response":"- Wildfires in Canada are sending smoke and air pollution across parts of the US, triggering air quality alerts from Maine to Minnesota. Concentrations of particulate matter have exceeded safety levels.\n\n- Weather systems are channeling the smoke through Pennsylvania into the Mid-Atlantic and Northeast regions. New York City has canceled outdoor activities to keep children and vulnerable groups indoors.\n\n- Very small particulate matter can enter the lungs and impact respiratory, cardiovascular and neurological health. Young children, the elderly and those with preexisting conditions are most at risk.\n\n- The conditions causing the poor air quality could get worse or shift to different areas in coming days depending on weather patterns. More wildfires may also contribute to higher concentrations.\n\n- Climate change is leading to longer and more severe fire seasons. Events of smoke traveling long distances and affecting air quality over wide areas will likely become more common in the future.\u0022\n","usage":{"input_tokens":27,"output_tokens":3}}
    /// </summary>
    public readonly partial struct LemurSummaryResponse : global::System.IEquatable<LemurSummaryResponse>
    {
        /// <summary>
        /// Example: {"request_id":"5e1b27c2-691f-4414-8bc5-f14678442f9e","response":"Based on the transcript, the following locations were mentioned as being affected by wildfire smoke from Canada:\n\n- Maine\n- Maryland\n- Minnesota\n- Mid Atlantic region\n- Northeast region\n- New York City\n- Baltimore\n","usage":{"input_tokens":27,"output_tokens":3}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LemurStringResponse? String { get; init; }
#else
        public global::G.LemurStringResponse? String { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(String))]
#endif
        public bool IsString => String != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurSummaryResponse(global::G.LemurStringResponse value) => new LemurSummaryResponse((global::G.LemurStringResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurStringResponse?(LemurSummaryResponse @this) => @this.String;

        /// <summary>
        /// 
        /// </summary>
        public LemurSummaryResponse(global::G.LemurStringResponse? value)
        {
            String = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            String as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            String?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsString;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LemurStringResponse?, TResult>? @string = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString && @string != null)
            {
                return @string(String!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LemurStringResponse?>? @string = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                String,
                typeof(global::G.LemurStringResponse),
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
        public bool Equals(LemurSummaryResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LemurStringResponse?>.Default.Equals(String, other.String) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LemurSummaryResponse obj1, LemurSummaryResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LemurSummaryResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LemurSummaryResponse obj1, LemurSummaryResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LemurSummaryResponse o && Equals(o);
        }
    }
}
