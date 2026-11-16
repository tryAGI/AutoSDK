//HintName: G.Models.Content.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Multi-modal input and output contents.
    /// </summary>
    public readonly partial struct Content : global::System.IEquatable<Content>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputContent? Input { get; init; }
#else
        public global::G.InputContent? Input { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Input))]
#endif
        public bool IsInput => Input != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.InputContent? value)
        {
            value = Input;
            return IsInput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.InputContent PickInput() => Input is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Input' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputContent? Output { get; init; }
#else
        public global::G.OutputContent? Output { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Output))]
#endif
        public bool IsOutput => Output != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.OutputContent? value)
        {
            value = Output;
            return IsOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.OutputContent PickOutput() => Output is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Output' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Content(global::G.InputContent value) => new Content((global::G.InputContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputContent?(Content @this) => @this.Input;

        /// <summary>
        /// 
        /// </summary>
        public Content(global::G.InputContent? value)
        {
            Input = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Content FromInput(global::G.InputContent? value) => new Content(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Content(global::G.OutputContent value) => new Content((global::G.OutputContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputContent?(Content @this) => @this.Output;

        /// <summary>
        /// 
        /// </summary>
        public Content(global::G.OutputContent? value)
        {
            Output = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Content FromOutput(global::G.OutputContent? value) => new Content(value);

        /// <summary>
        /// 
        /// </summary>
        public Content(
            global::G.InputContent? input,
            global::G.OutputContent? output
            )
        {
            Input = input;
            Output = output;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Output as object ??
            Input as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Input?.ToString() ??
            Output?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInput && !IsOutput || !IsInput && IsOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InputContent?, TResult>? input = null,
            global::System.Func<global::G.OutputContent?, TResult>? output = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Input is { } __value0 && input != null)
            {
                return input(__value0);
            }
            else if (Output is { } __value1 && output != null)
            {
                return output(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InputContent?>? input = null,

            global::System.Action<global::G.OutputContent?>? output = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Input is { } __value0)
            {
                input?.Invoke(__value0);
            }
            else if (Output is { } __value1)
            {
                output?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.InputContent?>? input = null,
            global::System.Action<global::G.OutputContent?>? output = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Input is { } __value0)
            {
                input?.Invoke(__value0);
            }
            else if (Output is { } __value1)
            {
                output?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Input,
                typeof(global::G.InputContent),
                Output,
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
        public bool Equals(Content other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InputContent?>.Default.Equals(Input, other.Input) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputContent?>.Default.Equals(Output, other.Output) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Content obj1, Content obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Content>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Content obj1, Content obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Content o && Equals(o);
        }
    }
}
