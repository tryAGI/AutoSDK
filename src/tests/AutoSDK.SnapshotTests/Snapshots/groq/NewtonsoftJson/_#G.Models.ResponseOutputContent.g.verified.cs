//HintName: G.Models.ResponseOutputContent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponseOutputContent : global::System.IEquatable<ResponseOutputContent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseOutputContentDiscriminatorType? Type { get; }

        /// <summary>
        /// A text output from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseOutputTextContent? OutputText { get; init; }
#else
        public global::G.ResponseOutputTextContent? OutputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputText))]
#endif
        public bool IsOutputText => OutputText != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseOutputContent(global::G.ResponseOutputTextContent value) => new ResponseOutputContent((global::G.ResponseOutputTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseOutputTextContent?(ResponseOutputContent @this) => @this.OutputText;

        /// <summary>
        /// 
        /// </summary>
        public ResponseOutputContent(global::G.ResponseOutputTextContent? value)
        {
            OutputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseOutputContent(
            global::G.ResponseOutputContentDiscriminatorType? type,
            global::G.ResponseOutputTextContent? outputText
            )
        {
            Type = type;

            OutputText = outputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputText?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResponseOutputTextContent?, TResult>? outputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputText && outputText != null)
            {
                return outputText(OutputText!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResponseOutputTextContent?>? outputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputText)
            {
                outputText?.Invoke(OutputText!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputText,
                typeof(global::G.ResponseOutputTextContent),
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
        public bool Equals(ResponseOutputContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseOutputTextContent?>.Default.Equals(OutputText, other.OutputText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseOutputContent obj1, ResponseOutputContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseOutputContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseOutputContent obj1, ResponseOutputContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseOutputContent o && Equals(o);
        }
    }
}
