//HintName: G.Models.ResponseInputContent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponseInputContent : global::System.IEquatable<ResponseInputContent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseInputContentDiscriminatorType? Type { get; }

        /// <summary>
        /// A text input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseInputTextContent? InputText { get; init; }
#else
        public global::G.ResponseInputTextContent? InputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputText))]
#endif
        public bool IsInputText => InputText != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseInputContent(global::G.ResponseInputTextContent value) => new ResponseInputContent((global::G.ResponseInputTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseInputTextContent?(ResponseInputContent @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public ResponseInputContent(global::G.ResponseInputTextContent? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseInputContent(
            global::G.ResponseInputContentDiscriminatorType? type,
            global::G.ResponseInputTextContent? inputText
            )
        {
            Type = type;

            InputText = inputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResponseInputTextContent?, TResult>? inputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText && inputText != null)
            {
                return inputText(InputText!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResponseInputTextContent?>? inputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputText,
                typeof(global::G.ResponseInputTextContent),
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
        public bool Equals(ResponseInputContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseInputTextContent?>.Default.Equals(InputText, other.InputText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseInputContent obj1, ResponseInputContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseInputContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseInputContent obj1, ResponseInputContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseInputContent o && Equals(o);
        }
    }
}
