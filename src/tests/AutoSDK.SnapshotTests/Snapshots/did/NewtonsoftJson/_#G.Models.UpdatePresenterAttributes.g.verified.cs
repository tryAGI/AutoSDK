//HintName: G.Models.UpdatePresenterAttributes.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UpdatePresenterAttributes : global::System.IEquatable<UpdatePresenterAttributes>
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdatePresenterAttributesVariant1? UpdatePresenterAttributesVariant1 { get; init; }
#else
        public global::G.UpdatePresenterAttributesVariant1? UpdatePresenterAttributesVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdatePresenterAttributesVariant1))]
#endif
        public bool IsUpdatePresenterAttributesVariant1 => UpdatePresenterAttributesVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdatePresenterAttributesVariant2? UpdatePresenterAttributesVariant2 { get; init; }
#else
        public global::G.UpdatePresenterAttributesVariant2? UpdatePresenterAttributesVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdatePresenterAttributesVariant2))]
#endif
        public bool IsUpdatePresenterAttributesVariant2 => UpdatePresenterAttributesVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdatePresenterAttributesVariant3? UpdatePresenterAttributesVariant3 { get; init; }
#else
        public global::G.UpdatePresenterAttributesVariant3? UpdatePresenterAttributesVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdatePresenterAttributesVariant3))]
#endif
        public bool IsUpdatePresenterAttributesVariant3 => UpdatePresenterAttributesVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdatePresenterAttributes(global::G.UpdatePresenterAttributesVariant1 value) => new UpdatePresenterAttributes((global::G.UpdatePresenterAttributesVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdatePresenterAttributesVariant1?(UpdatePresenterAttributes @this) => @this.UpdatePresenterAttributesVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UpdatePresenterAttributes(global::G.UpdatePresenterAttributesVariant1? value)
        {
            UpdatePresenterAttributesVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdatePresenterAttributes(global::G.UpdatePresenterAttributesVariant2 value) => new UpdatePresenterAttributes((global::G.UpdatePresenterAttributesVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdatePresenterAttributesVariant2?(UpdatePresenterAttributes @this) => @this.UpdatePresenterAttributesVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UpdatePresenterAttributes(global::G.UpdatePresenterAttributesVariant2? value)
        {
            UpdatePresenterAttributesVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdatePresenterAttributes(global::G.UpdatePresenterAttributesVariant3 value) => new UpdatePresenterAttributes((global::G.UpdatePresenterAttributesVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdatePresenterAttributesVariant3?(UpdatePresenterAttributes @this) => @this.UpdatePresenterAttributesVariant3;

        /// <summary>
        /// 
        /// </summary>
        public UpdatePresenterAttributes(global::G.UpdatePresenterAttributesVariant3? value)
        {
            UpdatePresenterAttributesVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdatePresenterAttributes(
            global::G.UpdatePresenterAttributesVariant1? updatePresenterAttributesVariant1,
            global::G.UpdatePresenterAttributesVariant2? updatePresenterAttributesVariant2,
            global::G.UpdatePresenterAttributesVariant3? updatePresenterAttributesVariant3
            )
        {
            UpdatePresenterAttributesVariant1 = updatePresenterAttributesVariant1;
            UpdatePresenterAttributesVariant2 = updatePresenterAttributesVariant2;
            UpdatePresenterAttributesVariant3 = updatePresenterAttributesVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UpdatePresenterAttributesVariant3 as object ??
            UpdatePresenterAttributesVariant2 as object ??
            UpdatePresenterAttributesVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UpdatePresenterAttributesVariant1?.ToString() ??
            UpdatePresenterAttributesVariant2?.ToString() ??
            UpdatePresenterAttributesVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUpdatePresenterAttributesVariant1 && IsUpdatePresenterAttributesVariant2 && IsUpdatePresenterAttributesVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.UpdatePresenterAttributesVariant1?, TResult>? updatePresenterAttributesVariant1 = null,
            global::System.Func<global::G.UpdatePresenterAttributesVariant2?, TResult>? updatePresenterAttributesVariant2 = null,
            global::System.Func<global::G.UpdatePresenterAttributesVariant3?, TResult>? updatePresenterAttributesVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdatePresenterAttributesVariant1 && updatePresenterAttributesVariant1 != null)
            {
                return updatePresenterAttributesVariant1(UpdatePresenterAttributesVariant1!);
            }
            else if (IsUpdatePresenterAttributesVariant2 && updatePresenterAttributesVariant2 != null)
            {
                return updatePresenterAttributesVariant2(UpdatePresenterAttributesVariant2!);
            }
            else if (IsUpdatePresenterAttributesVariant3 && updatePresenterAttributesVariant3 != null)
            {
                return updatePresenterAttributesVariant3(UpdatePresenterAttributesVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.UpdatePresenterAttributesVariant1?>? updatePresenterAttributesVariant1 = null,
            global::System.Action<global::G.UpdatePresenterAttributesVariant2?>? updatePresenterAttributesVariant2 = null,
            global::System.Action<global::G.UpdatePresenterAttributesVariant3?>? updatePresenterAttributesVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdatePresenterAttributesVariant1)
            {
                updatePresenterAttributesVariant1?.Invoke(UpdatePresenterAttributesVariant1!);
            }
            else if (IsUpdatePresenterAttributesVariant2)
            {
                updatePresenterAttributesVariant2?.Invoke(UpdatePresenterAttributesVariant2!);
            }
            else if (IsUpdatePresenterAttributesVariant3)
            {
                updatePresenterAttributesVariant3?.Invoke(UpdatePresenterAttributesVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UpdatePresenterAttributesVariant1,
                typeof(global::G.UpdatePresenterAttributesVariant1),
                UpdatePresenterAttributesVariant2,
                typeof(global::G.UpdatePresenterAttributesVariant2),
                UpdatePresenterAttributesVariant3,
                typeof(global::G.UpdatePresenterAttributesVariant3),
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
        public bool Equals(UpdatePresenterAttributes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.UpdatePresenterAttributesVariant1?>.Default.Equals(UpdatePresenterAttributesVariant1, other.UpdatePresenterAttributesVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdatePresenterAttributesVariant2?>.Default.Equals(UpdatePresenterAttributesVariant2, other.UpdatePresenterAttributesVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdatePresenterAttributesVariant3?>.Default.Equals(UpdatePresenterAttributesVariant3, other.UpdatePresenterAttributesVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdatePresenterAttributes obj1, UpdatePresenterAttributes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdatePresenterAttributes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdatePresenterAttributes obj1, UpdatePresenterAttributes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdatePresenterAttributes o && Equals(o);
        }
    }
}
