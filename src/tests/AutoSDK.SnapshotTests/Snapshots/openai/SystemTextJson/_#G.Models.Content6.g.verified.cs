//HintName: G.Models.Content6.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Multi-modal input and output contents.
    /// </summary>
    public readonly partial struct Content6 : global::System.IEquatable<Content6>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputContent? InputContent { get; init; }
#else
        public global::G.InputContent? InputContent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputContent))]
#endif
        public bool IsInputContent => InputContent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Content6(global::G.InputContent value) => new Content6(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputContent?(Content6 @this) => @this.InputContent;

        /// <summary>
        /// 
        /// </summary>
        public Content6(global::G.InputContent? value)
        {
            InputContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputContent? OutputContent { get; init; }
#else
        public global::G.OutputContent? OutputContent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputContent))]
#endif
        public bool IsOutputContent => OutputContent != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Content6(global::G.OutputContent value) => new Content6(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputContent?(Content6 @this) => @this.OutputContent;

        /// <summary>
        /// 
        /// </summary>
        public Content6(global::G.OutputContent? value)
        {
            OutputContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Content6(
            global::G.InputContent? inputContent,
            global::G.OutputContent? outputContent
            )
        {
            InputContent = inputContent;
            OutputContent = outputContent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputContent as object ??
            InputContent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputContent?.ToString() ??
            OutputContent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputContent && !IsOutputContent || !IsInputContent && IsOutputContent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputContent?, TResult>? inputContent = null,
            global::System.Func<global::G.OutputContent?, TResult>? outputContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputContent && inputContent != null)
            {
                return inputContent(InputContent!);
            }
            else if (IsOutputContent && outputContent != null)
            {
                return outputContent(OutputContent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InputContent?>? inputContent = null,
            global::System.Action<global::G.OutputContent?>? outputContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputContent)
            {
                inputContent?.Invoke(InputContent!);
            }
            else if (IsOutputContent)
            {
                outputContent?.Invoke(OutputContent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputContent,
                typeof(global::G.InputContent),
                OutputContent,
                typeof(global::G.OutputContent),
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
        public bool Equals(Content6 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InputContent?>.Default.Equals(InputContent, other.InputContent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputContent?>.Default.Equals(OutputContent, other.OutputContent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Content6 obj1, Content6 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Content6>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Content6 obj1, Content6 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Content6 o && Equals(o);
        }
    }
}
