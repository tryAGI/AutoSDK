//HintName: G.Models.CodeInterpreterServerToolContainer.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CodeInterpreterServerToolContainer : global::System.IEquatable<CodeInterpreterServerToolContainer>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? CodeInterpreterServerToolContainerVariant1 { get; init; }
#else
        public string? CodeInterpreterServerToolContainerVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterServerToolContainerVariant1))]
#endif
        public bool IsCodeInterpreterServerToolContainerVariant1 => CodeInterpreterServerToolContainerVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeInterpreterServerToolContainer1? CodeInterpreterServerToolContainer1 { get; init; }
#else
        public global::G.CodeInterpreterServerToolContainer1? CodeInterpreterServerToolContainer1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterServerToolContainer1))]
#endif
        public bool IsCodeInterpreterServerToolContainer1 => CodeInterpreterServerToolContainer1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeInterpreterServerToolContainer(string value) => new CodeInterpreterServerToolContainer((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(CodeInterpreterServerToolContainer @this) => @this.CodeInterpreterServerToolContainerVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterServerToolContainer(string? value)
        {
            CodeInterpreterServerToolContainerVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeInterpreterServerToolContainer(global::G.CodeInterpreterServerToolContainer1 value) => new CodeInterpreterServerToolContainer((global::G.CodeInterpreterServerToolContainer1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeInterpreterServerToolContainer1?(CodeInterpreterServerToolContainer @this) => @this.CodeInterpreterServerToolContainer1;

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterServerToolContainer(global::G.CodeInterpreterServerToolContainer1? value)
        {
            CodeInterpreterServerToolContainer1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterServerToolContainer(
            string? codeInterpreterServerToolContainerVariant1,
            global::G.CodeInterpreterServerToolContainer1? codeInterpreterServerToolContainer1
            )
        {
            CodeInterpreterServerToolContainerVariant1 = codeInterpreterServerToolContainerVariant1;
            CodeInterpreterServerToolContainer1 = codeInterpreterServerToolContainer1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CodeInterpreterServerToolContainer1 as object ??
            CodeInterpreterServerToolContainerVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CodeInterpreterServerToolContainerVariant1?.ToString() ??
            CodeInterpreterServerToolContainer1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCodeInterpreterServerToolContainerVariant1 && !IsCodeInterpreterServerToolContainer1 || !IsCodeInterpreterServerToolContainerVariant1 && IsCodeInterpreterServerToolContainer1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? codeInterpreterServerToolContainerVariant1 = null,
            global::System.Func<global::G.CodeInterpreterServerToolContainer1?, TResult>? codeInterpreterServerToolContainer1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreterServerToolContainerVariant1 && codeInterpreterServerToolContainerVariant1 != null)
            {
                return codeInterpreterServerToolContainerVariant1(CodeInterpreterServerToolContainerVariant1!);
            }
            else if (IsCodeInterpreterServerToolContainer1 && codeInterpreterServerToolContainer1 != null)
            {
                return codeInterpreterServerToolContainer1(CodeInterpreterServerToolContainer1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? codeInterpreterServerToolContainerVariant1 = null,
            global::System.Action<global::G.CodeInterpreterServerToolContainer1?>? codeInterpreterServerToolContainer1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreterServerToolContainerVariant1)
            {
                codeInterpreterServerToolContainerVariant1?.Invoke(CodeInterpreterServerToolContainerVariant1!);
            }
            else if (IsCodeInterpreterServerToolContainer1)
            {
                codeInterpreterServerToolContainer1?.Invoke(CodeInterpreterServerToolContainer1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CodeInterpreterServerToolContainerVariant1,
                typeof(string),
                CodeInterpreterServerToolContainer1,
                typeof(global::G.CodeInterpreterServerToolContainer1),
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
        public bool Equals(CodeInterpreterServerToolContainer other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(CodeInterpreterServerToolContainerVariant1, other.CodeInterpreterServerToolContainerVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeInterpreterServerToolContainer1?>.Default.Equals(CodeInterpreterServerToolContainer1, other.CodeInterpreterServerToolContainer1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CodeInterpreterServerToolContainer obj1, CodeInterpreterServerToolContainer obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CodeInterpreterServerToolContainer>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CodeInterpreterServerToolContainer obj1, CodeInterpreterServerToolContainer obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CodeInterpreterServerToolContainer o && Equals(o);
        }
    }
}
