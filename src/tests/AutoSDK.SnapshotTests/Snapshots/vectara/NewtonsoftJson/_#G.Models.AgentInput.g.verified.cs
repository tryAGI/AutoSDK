//HintName: G.Models.AgentInput.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An input that can be provided to an agent message.
    /// </summary>
    public readonly partial struct AgentInput : global::System.IEquatable<AgentInput>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AgentInputDiscriminatorType? Type { get; }

        /// <summary>
        /// A text input for an agent message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentTextInput? Text { get; init; }
#else
        public global::G.AgentTextInput? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// An input that invokes a skill by name.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentSkillInput? Skill { get; init; }
#else
        public global::G.AgentSkillInput? Skill { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Skill))]
#endif
        public bool IsSkill => Skill != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentInput(global::G.AgentTextInput value) => new AgentInput((global::G.AgentTextInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentTextInput?(AgentInput @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public AgentInput(global::G.AgentTextInput? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentInput(global::G.AgentSkillInput value) => new AgentInput((global::G.AgentSkillInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentSkillInput?(AgentInput @this) => @this.Skill;

        /// <summary>
        /// 
        /// </summary>
        public AgentInput(global::G.AgentSkillInput? value)
        {
            Skill = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentInput(
            global::G.AgentInputDiscriminatorType? type,
            global::G.AgentTextInput? text,
            global::G.AgentSkillInput? skill
            )
        {
            Type = type;

            Text = text;
            Skill = skill;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Skill as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Skill?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsSkill || !IsText && IsSkill;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AgentTextInput?, TResult>? text = null,
            global::System.Func<global::G.AgentSkillInput?, TResult>? skill = null,
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
            else if (IsSkill && skill != null)
            {
                return skill(Skill!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AgentTextInput?>? text = null,
            global::System.Action<global::G.AgentSkillInput?>? skill = null,
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
            else if (IsSkill)
            {
                skill?.Invoke(Skill!);
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
                typeof(global::G.AgentTextInput),
                Skill,
                typeof(global::G.AgentSkillInput),
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
        public bool Equals(AgentInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AgentTextInput?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AgentSkillInput?>.Default.Equals(Skill, other.Skill) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentInput obj1, AgentInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentInput obj1, AgentInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentInput o && Equals(o);
        }
    }
}
