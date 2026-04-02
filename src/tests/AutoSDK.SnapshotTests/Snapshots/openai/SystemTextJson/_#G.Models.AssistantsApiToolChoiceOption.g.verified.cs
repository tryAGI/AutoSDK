//HintName: G.Models.AssistantsApiToolChoiceOption.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Controls which (if any) tool is called by the model.<br/>
    /// `none` means the model will not call any tools and instead generates a message.<br/>
    /// `auto` is the default value and means the model can pick between generating a message or calling one or more tools.<br/>
    /// `required` means the model must call one or more tools before responding to the user.<br/>
    /// Specifying a particular tool like `{"type": "file_search"}` or `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.
    /// </summary>
    public readonly partial struct AssistantsApiToolChoiceOption : global::System.IEquatable<AssistantsApiToolChoiceOption>
    {
        /// <summary>
        /// `none` means the model will not call any tools and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools before responding to the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantsApiToolChoiceOptionEnum? Enum { get; init; }
#else
        public global::G.AssistantsApiToolChoiceOptionEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        /// Specifies a tool the model should use. Use to force the model to call a specific tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantsNamedToolChoice? Named { get; init; }
#else
        public global::G.AssistantsNamedToolChoice? Named { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Named))]
#endif
        public bool IsNamed => Named != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantsApiToolChoiceOption(global::G.AssistantsApiToolChoiceOptionEnum value) => new AssistantsApiToolChoiceOption((global::G.AssistantsApiToolChoiceOptionEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantsApiToolChoiceOptionEnum?(AssistantsApiToolChoiceOption @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiToolChoiceOption(global::G.AssistantsApiToolChoiceOptionEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantsApiToolChoiceOption(global::G.AssistantsNamedToolChoice value) => new AssistantsApiToolChoiceOption((global::G.AssistantsNamedToolChoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantsNamedToolChoice?(AssistantsApiToolChoiceOption @this) => @this.Named;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiToolChoiceOption(global::G.AssistantsNamedToolChoice? value)
        {
            Named = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiToolChoiceOption(
            global::G.AssistantsApiToolChoiceOptionEnum? @enum,
            global::G.AssistantsNamedToolChoice? named
            )
        {
            Enum = @enum;
            Named = named;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Named as object ??
            Enum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            Named?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnum && !IsNamed || !IsEnum && IsNamed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AssistantsApiToolChoiceOptionEnum?, TResult>? @enum = null,
            global::System.Func<global::G.AssistantsNamedToolChoice?, TResult>? named = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsNamed && named != null)
            {
                return named(Named!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AssistantsApiToolChoiceOptionEnum?>? @enum = null,
            global::System.Action<global::G.AssistantsNamedToolChoice?>? named = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsNamed)
            {
                named?.Invoke(Named!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enum,
                typeof(global::G.AssistantsApiToolChoiceOptionEnum),
                Named,
                typeof(global::G.AssistantsNamedToolChoice),
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
        public bool Equals(AssistantsApiToolChoiceOption other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantsApiToolChoiceOptionEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantsNamedToolChoice?>.Default.Equals(Named, other.Named) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AssistantsApiToolChoiceOption obj1, AssistantsApiToolChoiceOption obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AssistantsApiToolChoiceOption>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AssistantsApiToolChoiceOption obj1, AssistantsApiToolChoiceOption obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AssistantsApiToolChoiceOption o && Equals(o);
        }
    }
}
