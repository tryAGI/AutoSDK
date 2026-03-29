//HintName: G.Models.FunctionDataNullish.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FunctionDataNullish : global::System.IEquatable<FunctionDataNullish>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionDataNullishPrompt? Prompt { get; init; }
#else
        public global::G.FunctionDataNullishPrompt? Prompt { get; }
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
        public global::G.FunctionDataNullishCode? Code { get; init; }
#else
        public global::G.FunctionDataNullishCode? Code { get; }
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
        public global::G.FunctionDataNullishRemoteEval? RemoteEval { get; init; }
#else
        public global::G.FunctionDataNullishRemoteEval? RemoteEval { get; }
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
        public global::G.FunctionDataNullishGlobal? Global { get; init; }
#else
        public global::G.FunctionDataNullishGlobal? Global { get; }
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
        public global::G.FunctionDataNullishParameters? Parameters { get; init; }
#else
        public global::G.FunctionDataNullishParameters? Parameters { get; }
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
        public global::G.AllOf<global::G.TopicMapData, object>? Value9 { get; init; }
#else
        public global::G.AllOf<global::G.TopicMapData, object>? Value9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value10 { get; init; }
#else
        public object? Value10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::G.FunctionDataNullishPrompt value) => new FunctionDataNullish((global::G.FunctionDataNullishPrompt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionDataNullishPrompt?(FunctionDataNullish @this) => @this.Prompt;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::G.FunctionDataNullishPrompt? value)
        {
            Prompt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::G.FunctionDataNullishCode value) => new FunctionDataNullish((global::G.FunctionDataNullishCode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionDataNullishCode?(FunctionDataNullish @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::G.FunctionDataNullishCode? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::G.GraphData value) => new FunctionDataNullish((global::G.GraphData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphData?(FunctionDataNullish @this) => @this.Graph;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::G.GraphData? value)
        {
            Graph = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::G.FunctionDataNullishRemoteEval value) => new FunctionDataNullish((global::G.FunctionDataNullishRemoteEval?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionDataNullishRemoteEval?(FunctionDataNullish @this) => @this.RemoteEval;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::G.FunctionDataNullishRemoteEval? value)
        {
            RemoteEval = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::G.FunctionDataNullishGlobal value) => new FunctionDataNullish((global::G.FunctionDataNullishGlobal?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionDataNullishGlobal?(FunctionDataNullish @this) => @this.Global;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::G.FunctionDataNullishGlobal? value)
        {
            Global = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::G.FacetData value) => new FunctionDataNullish((global::G.FacetData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FacetData?(FunctionDataNullish @this) => @this.Facet;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::G.FacetData? value)
        {
            Facet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::G.BatchedFacetData value) => new FunctionDataNullish((global::G.BatchedFacetData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BatchedFacetData?(FunctionDataNullish @this) => @this.BatchedFacet;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::G.BatchedFacetData? value)
        {
            BatchedFacet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::G.FunctionDataNullishParameters value) => new FunctionDataNullish((global::G.FunctionDataNullishParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionDataNullishParameters?(FunctionDataNullish @this) => @this.Parameters;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::G.FunctionDataNullishParameters? value)
        {
            Parameters = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionDataNullish(global::G.AllOf<global::G.TopicMapData, object> value) => new FunctionDataNullish((global::G.AllOf<global::G.TopicMapData, object>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.TopicMapData, object>?(FunctionDataNullish @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(global::G.AllOf<global::G.TopicMapData, object>? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FunctionDataNullish(
            global::G.FunctionDataNullishPrompt? prompt,
            global::G.FunctionDataNullishCode? code,
            global::G.GraphData? graph,
            global::G.FunctionDataNullishRemoteEval? remoteEval,
            global::G.FunctionDataNullishGlobal? global,
            global::G.FacetData? facet,
            global::G.BatchedFacetData? batchedFacet,
            global::G.FunctionDataNullishParameters? parameters,
            global::G.AllOf<global::G.TopicMapData, object>? value9,
            object? value10
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
            Value9 = value9;
            Value10 = value10;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value10 as object ??
            Value9 as object ??
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
            Value9?.ToString() ??
            Value10?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPrompt || IsCode || IsGraph || IsRemoteEval || IsGlobal || IsFacet || IsBatchedFacet || IsParameters || IsValue9 || IsValue10;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FunctionDataNullishPrompt?, TResult>? prompt = null,
            global::System.Func<global::G.FunctionDataNullishCode?, TResult>? code = null,
            global::System.Func<global::G.GraphData?, TResult>? graph = null,
            global::System.Func<global::G.FunctionDataNullishRemoteEval?, TResult>? remoteEval = null,
            global::System.Func<global::G.FunctionDataNullishGlobal?, TResult>? global = null,
            global::System.Func<global::G.FacetData?, TResult>? facet = null,
            global::System.Func<global::G.BatchedFacetData?, TResult>? batchedFacet = null,
            global::System.Func<global::G.FunctionDataNullishParameters?, TResult>? parameters = null,
            global::System.Func<global::G.AllOf<global::G.TopicMapData, object>?, TResult>? value9 = null,
            global::System.Func<object?, TResult>? value10 = null,
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
            else if (IsValue9 && value9 != null)
            {
                return value9(Value9!);
            }
            else if (IsValue10 && value10 != null)
            {
                return value10(Value10!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.FunctionDataNullishPrompt?>? prompt = null,
            global::System.Action<global::G.FunctionDataNullishCode?>? code = null,
            global::System.Action<global::G.GraphData?>? graph = null,
            global::System.Action<global::G.FunctionDataNullishRemoteEval?>? remoteEval = null,
            global::System.Action<global::G.FunctionDataNullishGlobal?>? global = null,
            global::System.Action<global::G.FacetData?>? facet = null,
            global::System.Action<global::G.BatchedFacetData?>? batchedFacet = null,
            global::System.Action<global::G.FunctionDataNullishParameters?>? parameters = null,
            global::System.Action<global::G.AllOf<global::G.TopicMapData, object>?>? value9 = null,
            global::System.Action<object?>? value10 = null,
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
            else if (IsValue9)
            {
                value9?.Invoke(Value9!);
            }
            else if (IsValue10)
            {
                value10?.Invoke(Value10!);
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
                typeof(global::G.FunctionDataNullishPrompt),
                Code,
                typeof(global::G.FunctionDataNullishCode),
                Graph,
                typeof(global::G.GraphData),
                RemoteEval,
                typeof(global::G.FunctionDataNullishRemoteEval),
                Global,
                typeof(global::G.FunctionDataNullishGlobal),
                Facet,
                typeof(global::G.FacetData),
                BatchedFacet,
                typeof(global::G.BatchedFacetData),
                Parameters,
                typeof(global::G.FunctionDataNullishParameters),
                Value9,
                typeof(global::G.AllOf<global::G.TopicMapData, object>),
                Value10,
                typeof(object),
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
        public bool Equals(FunctionDataNullish other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionDataNullishPrompt?>.Default.Equals(Prompt, other.Prompt) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionDataNullishCode?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphData?>.Default.Equals(Graph, other.Graph) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionDataNullishRemoteEval?>.Default.Equals(RemoteEval, other.RemoteEval) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionDataNullishGlobal?>.Default.Equals(Global, other.Global) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FacetData?>.Default.Equals(Facet, other.Facet) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BatchedFacetData?>.Default.Equals(BatchedFacet, other.BatchedFacet) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionDataNullishParameters?>.Default.Equals(Parameters, other.Parameters) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.TopicMapData, object>?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value10, other.Value10) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FunctionDataNullish obj1, FunctionDataNullish obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionDataNullish>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FunctionDataNullish obj1, FunctionDataNullish obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionDataNullish o && Equals(o);
        }
    }
}
