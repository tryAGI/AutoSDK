//HintName: G.Models.PostDialDigitsVariant12.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PostDialDigitsVariant12 : global::System.IEquatable<PostDialDigitsVariant12>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PostDialDigitsStatic? Static { get; init; }
#else
        public global::G.PostDialDigitsStatic? Static { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Static))]
#endif
        public bool IsStatic => Static != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PostDialDigitsDynamicVariable? Dynamic { get; init; }
#else
        public global::G.PostDialDigitsDynamicVariable? Dynamic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dynamic))]
#endif
        public bool IsDynamic => Dynamic != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PostDialDigitsVariant12(global::G.PostDialDigitsStatic value) => new PostDialDigitsVariant12((global::G.PostDialDigitsStatic?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PostDialDigitsStatic?(PostDialDigitsVariant12 @this) => @this.Static;

        /// <summary>
        /// 
        /// </summary>
        public PostDialDigitsVariant12(global::G.PostDialDigitsStatic? value)
        {
            Static = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PostDialDigitsVariant12(global::G.PostDialDigitsDynamicVariable value) => new PostDialDigitsVariant12((global::G.PostDialDigitsDynamicVariable?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PostDialDigitsDynamicVariable?(PostDialDigitsVariant12 @this) => @this.Dynamic;

        /// <summary>
        /// 
        /// </summary>
        public PostDialDigitsVariant12(global::G.PostDialDigitsDynamicVariable? value)
        {
            Dynamic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PostDialDigitsVariant12(
            global::G.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType? type,
            global::G.PostDialDigitsStatic? @static,
            global::G.PostDialDigitsDynamicVariable? dynamic
            )
        {
            Type = type;

            Static = @static;
            Dynamic = dynamic;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Dynamic as object ??
            Static as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Static?.ToString() ??
            Dynamic?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStatic && !IsDynamic || !IsStatic && IsDynamic;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PostDialDigitsStatic?, TResult>? @static = null,
            global::System.Func<global::G.PostDialDigitsDynamicVariable?, TResult>? dynamic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStatic && @static != null)
            {
                return @static(Static!);
            }
            else if (IsDynamic && dynamic != null)
            {
                return dynamic(Dynamic!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PostDialDigitsStatic?>? @static = null,
            global::System.Action<global::G.PostDialDigitsDynamicVariable?>? dynamic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStatic)
            {
                @static?.Invoke(Static!);
            }
            else if (IsDynamic)
            {
                dynamic?.Invoke(Dynamic!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Static,
                typeof(global::G.PostDialDigitsStatic),
                Dynamic,
                typeof(global::G.PostDialDigitsDynamicVariable),
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
        public bool Equals(PostDialDigitsVariant12 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PostDialDigitsStatic?>.Default.Equals(Static, other.Static) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PostDialDigitsDynamicVariable?>.Default.Equals(Dynamic, other.Dynamic) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PostDialDigitsVariant12 obj1, PostDialDigitsVariant12 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PostDialDigitsVariant12>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PostDialDigitsVariant12 obj1, PostDialDigitsVariant12 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PostDialDigitsVariant12 o && Equals(o);
        }
    }
}
