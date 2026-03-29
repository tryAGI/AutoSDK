//HintName: G.Models.LLMConfig.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LLMConfig : global::System.IEquatable<LLMConfig>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LLMConfigOpenAI? OpenAI { get; init; }
#else
        public global::G.LLMConfigOpenAI? OpenAI { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAI))]
#endif
        public bool IsOpenAI => OpenAI != null;

        /// <summary>
        /// OpenAI External LLM
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LLMConfigVariant2? Value2 { get; init; }
#else
        public global::G.LLMConfigVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// Azure OpenAI External LLM
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LLMConfigVariant3? Value3 { get; init; }
#else
        public global::G.LLMConfigVariant3? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LLMConfigDId? DId { get; init; }
#else
        public global::G.LLMConfigDId? DId { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DId))]
#endif
        public bool IsDId => DId != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LLMConfigGoogle? Google { get; init; }
#else
        public global::G.LLMConfigGoogle? Google { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Google))]
#endif
        public bool IsGoogle => Google != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfig(global::G.LLMConfigOpenAI value) => new LLMConfig((global::G.LLMConfigOpenAI?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LLMConfigOpenAI?(LLMConfig @this) => @this.OpenAI;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfig(global::G.LLMConfigOpenAI? value)
        {
            OpenAI = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfig(global::G.LLMConfigVariant2 value) => new LLMConfig((global::G.LLMConfigVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LLMConfigVariant2?(LLMConfig @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfig(global::G.LLMConfigVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfig(global::G.LLMConfigVariant3 value) => new LLMConfig((global::G.LLMConfigVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LLMConfigVariant3?(LLMConfig @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfig(global::G.LLMConfigVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfig(global::G.LLMConfigDId value) => new LLMConfig((global::G.LLMConfigDId?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LLMConfigDId?(LLMConfig @this) => @this.DId;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfig(global::G.LLMConfigDId? value)
        {
            DId = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LLMConfig(global::G.LLMConfigGoogle value) => new LLMConfig((global::G.LLMConfigGoogle?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LLMConfigGoogle?(LLMConfig @this) => @this.Google;

        /// <summary>
        /// 
        /// </summary>
        public LLMConfig(global::G.LLMConfigGoogle? value)
        {
            Google = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LLMConfig(
            global::G.LLMConfigOpenAI? openAI,
            global::G.LLMConfigVariant2? value2,
            global::G.LLMConfigVariant3? value3,
            global::G.LLMConfigDId? dId,
            global::G.LLMConfigGoogle? google
            )
        {
            OpenAI = openAI;
            Value2 = value2;
            Value3 = value3;
            DId = dId;
            Google = google;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Google as object ??
            DId as object ??
            Value3 as object ??
            Value2 as object ??
            OpenAI as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenAI?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            DId?.ToString() ??
            Google?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenAI || IsValue2 || IsValue3 || IsDId || IsGoogle;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LLMConfigOpenAI?, TResult>? openAI = null,
            global::System.Func<global::G.LLMConfigVariant2?, TResult>? value2 = null,
            global::System.Func<global::G.LLMConfigVariant3?, TResult>? value3 = null,
            global::System.Func<global::G.LLMConfigDId?, TResult>? dId = null,
            global::System.Func<global::G.LLMConfigGoogle?, TResult>? google = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAI && openAI != null)
            {
                return openAI(OpenAI!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsDId && dId != null)
            {
                return dId(DId!);
            }
            else if (IsGoogle && google != null)
            {
                return google(Google!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LLMConfigOpenAI?>? openAI = null,
            global::System.Action<global::G.LLMConfigVariant2?>? value2 = null,
            global::System.Action<global::G.LLMConfigVariant3?>? value3 = null,
            global::System.Action<global::G.LLMConfigDId?>? dId = null,
            global::System.Action<global::G.LLMConfigGoogle?>? google = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAI)
            {
                openAI?.Invoke(OpenAI!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsDId)
            {
                dId?.Invoke(DId!);
            }
            else if (IsGoogle)
            {
                google?.Invoke(Google!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAI,
                typeof(global::G.LLMConfigOpenAI),
                Value2,
                typeof(global::G.LLMConfigVariant2),
                Value3,
                typeof(global::G.LLMConfigVariant3),
                DId,
                typeof(global::G.LLMConfigDId),
                Google,
                typeof(global::G.LLMConfigGoogle),
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
        public bool Equals(LLMConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LLMConfigOpenAI?>.Default.Equals(OpenAI, other.OpenAI) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LLMConfigVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LLMConfigVariant3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LLMConfigDId?>.Default.Equals(DId, other.DId) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LLMConfigGoogle?>.Default.Equals(Google, other.Google) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LLMConfig obj1, LLMConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LLMConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LLMConfig obj1, LLMConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LLMConfig o && Equals(o);
        }
    }
}
