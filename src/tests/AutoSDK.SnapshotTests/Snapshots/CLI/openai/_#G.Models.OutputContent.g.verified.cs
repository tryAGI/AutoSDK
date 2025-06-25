﻿//HintName: G.Models.OutputContent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputContent : global::System.IEquatable<OutputContent>
    {
        /// <summary>
        /// A text output from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputTextContent? Text { get; init; }
#else
        public global::G.OutputTextContent? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputContent(global::G.OutputTextContent value) => new OutputContent((global::G.OutputTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputTextContent?(OutputContent @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public OutputContent(global::G.OutputTextContent? value)
        {
            Text = value;
        }

        /// <summary>
        /// A refusal from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RefusalContent? Refusal { get; init; }
#else
        public global::G.RefusalContent? Refusal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Refusal))]
#endif
        public bool IsRefusal => Refusal != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputContent(global::G.RefusalContent value) => new OutputContent((global::G.RefusalContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RefusalContent?(OutputContent @this) => @this.Refusal;

        /// <summary>
        /// 
        /// </summary>
        public OutputContent(global::G.RefusalContent? value)
        {
            Refusal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputContent(
            global::G.OutputTextContent? text,
            global::G.RefusalContent? refusal
            )
        {
            Text = text;
            Refusal = refusal;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Refusal as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Refusal?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsRefusal || !IsText && IsRefusal;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OutputTextContent?, TResult>? text = null,
            global::System.Func<global::G.RefusalContent?, TResult>? refusal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsRefusal && refusal != null)
            {
                return refusal(Refusal!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OutputTextContent?>? text = null,
            global::System.Action<global::G.RefusalContent?>? refusal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsRefusal)
            {
                refusal?.Invoke(Refusal!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::G.OutputTextContent),
                Refusal,
                typeof(global::G.RefusalContent),
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
        public bool Equals(OutputContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OutputTextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RefusalContent?>.Default.Equals(Refusal, other.Refusal) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputContent obj1, OutputContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputContent obj1, OutputContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputContent o && Equals(o);
        }
    }
}
