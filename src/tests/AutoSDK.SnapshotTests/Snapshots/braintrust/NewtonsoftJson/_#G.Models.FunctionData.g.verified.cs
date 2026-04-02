//HintName: G.Models.FunctionData.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FunctionData : global::System.IEquatable<FunctionData>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionDataPrompt? Prompt { get; init; }
#else
        public global::G.FunctionDataPrompt? Prompt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Prompt))]
#endif
        public bool IsPrompt => Prompt != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionDataCode? Code { get; init; }
#else
        public global::G.FunctionDataCode? Code { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Code))]
#endif
        public bool IsCode => Code != null;

        /// <summary>
        /// This feature is preliminary and unsupported.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraphData? Graph { get; init; }
#else
        public global::G.GraphData? Graph { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Graph))]
#endif
        public bool IsGraph => Graph != null;

        /// <summary>
        /// A remote eval to run
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionDataRemoteEval? RemoteEval { get; init; }
#else
        public global::G.FunctionDataRemoteEval? RemoteEval { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RemoteEval))]
#endif
        public bool IsRemoteEval => RemoteEval != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionDataGlobal? Global { get; init; }
#else
        public global::G.FunctionDataGlobal? Global { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Global))]
#endif
        public bool IsGlobal => Global != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FacetData? Facet { get; init; }
#else
        public global::G.FacetData? Facet { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Facet))]
#endif
        public bool IsFacet => Facet != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BatchedFacetData? BatchedFacet { get; init; }
#else
        public global::G.BatchedFacetData? BatchedFacet { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BatchedFacet))]
#endif
        public bool IsBatchedFacet => BatchedFacet != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionDataParameters? Parameters { get; init; }
#else
        public global::G.FunctionDataParameters? Parameters { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Parameters))]
#endif
        public bool IsParameters => Parameters != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.TopicMapData, object>? FunctionDataVariant9 { get; init; }
#else
        public global::G.AllOf<global::G.TopicMapData, object>? FunctionDataVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionDataVariant9))]
#endif
        public bool IsFunctionDataVariant9 => FunctionDataVariant9 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::G.FunctionDataPrompt value) => new FunctionData((global::G.FunctionDataPrompt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionDataPrompt?(FunctionData @this) => @this.Prompt;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::G.FunctionDataPrompt? value)
        {
            Prompt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::G.FunctionDataCode value) => new FunctionData((global::G.FunctionDataCode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionDataCode?(FunctionData @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::G.FunctionDataCode? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::G.GraphData value) => new FunctionData((global::G.GraphData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphData?(FunctionData @this) => @this.Graph;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::G.GraphData? value)
        {
            Graph = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::G.FunctionDataRemoteEval value) => new FunctionData((global::G.FunctionDataRemoteEval?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionDataRemoteEval?(FunctionData @this) => @this.RemoteEval;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::G.FunctionDataRemoteEval? value)
        {
            RemoteEval = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::G.FunctionDataGlobal value) => new FunctionData((global::G.FunctionDataGlobal?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionDataGlobal?(FunctionData @this) => @this.Global;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::G.FunctionDataGlobal? value)
        {
            Global = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::G.FacetData value) => new FunctionData((global::G.FacetData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FacetData?(FunctionData @this) => @this.Facet;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::G.FacetData? value)
        {
            Facet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::G.BatchedFacetData value) => new FunctionData((global::G.BatchedFacetData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BatchedFacetData?(FunctionData @this) => @this.BatchedFacet;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::G.BatchedFacetData? value)
        {
            BatchedFacet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::G.FunctionDataParameters value) => new FunctionData((global::G.FunctionDataParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionDataParameters?(FunctionData @this) => @this.Parameters;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::G.FunctionDataParameters? value)
        {
            Parameters = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionData(global::G.AllOf<global::G.TopicMapData, object> value) => new FunctionData((global::G.AllOf<global::G.TopicMapData, object>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.TopicMapData, object>?(FunctionData @this) => @this.FunctionDataVariant9;

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(global::G.AllOf<global::G.TopicMapData, object>? value)
        {
            FunctionDataVariant9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FunctionData(
            global::G.FunctionDataPrompt? prompt,
            global::G.FunctionDataCode? code,
            global::G.GraphData? graph,
            global::G.FunctionDataRemoteEval? remoteEval,
            global::G.FunctionDataGlobal? global,
            global::G.FacetData? facet,
            global::G.BatchedFacetData? batchedFacet,
            global::G.FunctionDataParameters? parameters,
            global::G.AllOf<global::G.TopicMapData, object>? functionDataVariant9
            )
        {
            Prompt = prompt;
            Code = code;
            Graph = graph;
            RemoteEval = remoteEval;
            Global = global;
            Facet = facet;
            BatchedFacet = batchedFacet;
            Parameters = parameters;
            FunctionDataVariant9 = functionDataVariant9;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FunctionDataVariant9 as object ??
            Parameters as object ??
            BatchedFacet as object ??
            Facet as object ??
            Global as object ??
            RemoteEval as object ??
            Graph as object ??
            Code as object ??
            Prompt as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Prompt?.ToString() ??
            Code?.ToString() ??
            Graph?.ToString() ??
            RemoteEval?.ToString() ??
            Global?.ToString() ??
            Facet?.ToString() ??
            BatchedFacet?.ToString() ??
            Parameters?.ToString() ??
            FunctionDataVariant9?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPrompt || IsCode || IsGraph || IsRemoteEval || IsGlobal || IsFacet || IsBatchedFacet || IsParameters || IsFunctionDataVariant9;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FunctionDataPrompt?, TResult>? prompt = null,
            global::System.Func<global::G.FunctionDataCode?, TResult>? code = null,
            global::System.Func<global::G.GraphData?, TResult>? graph = null,
            global::System.Func<global::G.FunctionDataRemoteEval?, TResult>? remoteEval = null,
            global::System.Func<global::G.FunctionDataGlobal?, TResult>? global = null,
            global::System.Func<global::G.FacetData?, TResult>? facet = null,
            global::System.Func<global::G.BatchedFacetData?, TResult>? batchedFacet = null,
            global::System.Func<global::G.FunctionDataParameters?, TResult>? parameters = null,
            global::System.Func<global::G.AllOf<global::G.TopicMapData, object>?, TResult>? functionDataVariant9 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrompt && prompt != null)
            {
                return prompt(Prompt!);
            }
            else if (IsCode && code != null)
            {
                return code(Code!);
            }
            else if (IsGraph && graph != null)
            {
                return graph(Graph!);
            }
            else if (IsRemoteEval && remoteEval != null)
            {
                return remoteEval(RemoteEval!);
            }
            else if (IsGlobal && global != null)
            {
                return global(Global!);
            }
            else if (IsFacet && facet != null)
            {
                return facet(Facet!);
            }
            else if (IsBatchedFacet && batchedFacet != null)
            {
                return batchedFacet(BatchedFacet!);
            }
            else if (IsParameters && parameters != null)
            {
                return parameters(Parameters!);
            }
            else if (IsFunctionDataVariant9 && functionDataVariant9 != null)
            {
                return functionDataVariant9(FunctionDataVariant9!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.FunctionDataPrompt?>? prompt = null,
            global::System.Action<global::G.FunctionDataCode?>? code = null,
            global::System.Action<global::G.GraphData?>? graph = null,
            global::System.Action<global::G.FunctionDataRemoteEval?>? remoteEval = null,
            global::System.Action<global::G.FunctionDataGlobal?>? global = null,
            global::System.Action<global::G.FacetData?>? facet = null,
            global::System.Action<global::G.BatchedFacetData?>? batchedFacet = null,
            global::System.Action<global::G.FunctionDataParameters?>? parameters = null,
            global::System.Action<global::G.AllOf<global::G.TopicMapData, object>?>? functionDataVariant9 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrompt)
            {
                prompt?.Invoke(Prompt!);
            }
            else if (IsCode)
            {
                code?.Invoke(Code!);
            }
            else if (IsGraph)
            {
                graph?.Invoke(Graph!);
            }
            else if (IsRemoteEval)
            {
                remoteEval?.Invoke(RemoteEval!);
            }
            else if (IsGlobal)
            {
                global?.Invoke(Global!);
            }
            else if (IsFacet)
            {
                facet?.Invoke(Facet!);
            }
            else if (IsBatchedFacet)
            {
                batchedFacet?.Invoke(BatchedFacet!);
            }
            else if (IsParameters)
            {
                parameters?.Invoke(Parameters!);
            }
            else if (IsFunctionDataVariant9)
            {
                functionDataVariant9?.Invoke(FunctionDataVariant9!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Prompt,
                typeof(global::G.FunctionDataPrompt),
                Code,
                typeof(global::G.FunctionDataCode),
                Graph,
                typeof(global::G.GraphData),
                RemoteEval,
                typeof(global::G.FunctionDataRemoteEval),
                Global,
                typeof(global::G.FunctionDataGlobal),
                Facet,
                typeof(global::G.FacetData),
                BatchedFacet,
                typeof(global::G.BatchedFacetData),
                Parameters,
                typeof(global::G.FunctionDataParameters),
                FunctionDataVariant9,
                typeof(global::G.AllOf<global::G.TopicMapData, object>),
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
        public bool Equals(FunctionData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionDataPrompt?>.Default.Equals(Prompt, other.Prompt) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionDataCode?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphData?>.Default.Equals(Graph, other.Graph) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionDataRemoteEval?>.Default.Equals(RemoteEval, other.RemoteEval) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionDataGlobal?>.Default.Equals(Global, other.Global) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FacetData?>.Default.Equals(Facet, other.Facet) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BatchedFacetData?>.Default.Equals(BatchedFacet, other.BatchedFacet) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionDataParameters?>.Default.Equals(Parameters, other.Parameters) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.TopicMapData, object>?>.Default.Equals(FunctionDataVariant9, other.FunctionDataVariant9) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FunctionData obj1, FunctionData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FunctionData obj1, FunctionData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionData o && Equals(o);
        }
    }
}
