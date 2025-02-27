//HintName: G.Models.Model.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
    /// </summary>
    public readonly partial struct Model : global::System.IEquatable<Model>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? Value1 { get; init; }
#else
        public string? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Model(string value) => new Model(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(Model @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public Model(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// Our most intelligent model
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelVariant2? Value2 { get; init; }
#else
        public global::G.ModelVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Model(global::G.ModelVariant2 value) => new Model(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelVariant2?(Model @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public Model(global::G.ModelVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// Our most intelligent model
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelVariant3? Value3 { get; init; }
#else
        public global::G.ModelVariant3? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Model(global::G.ModelVariant3 value) => new Model(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelVariant3?(Model @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public Model(global::G.ModelVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// Fastest and most compact model for near-instant responsiveness
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelVariant4? Value4 { get; init; }
#else
        public global::G.ModelVariant4? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Model(global::G.ModelVariant4 value) => new Model(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelVariant4?(Model @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public Model(global::G.ModelVariant4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// Our fastest model
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelVariant5? Value5 { get; init; }
#else
        public global::G.ModelVariant5? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Model(global::G.ModelVariant5 value) => new Model(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelVariant5?(Model @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public Model(global::G.ModelVariant5? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// Our previous most intelligent model
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelVariant6? Value6 { get; init; }
#else
        public global::G.ModelVariant6? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Model(global::G.ModelVariant6 value) => new Model(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelVariant6?(Model @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public Model(global::G.ModelVariant6? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// Our previous most intelligent model
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelVariant7? Value7 { get; init; }
#else
        public global::G.ModelVariant7? Value7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Model(global::G.ModelVariant7 value) => new Model(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelVariant7?(Model @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public Model(global::G.ModelVariant7? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelVariant8? Value8 { get; init; }
#else
        public global::G.ModelVariant8? Value8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Model(global::G.ModelVariant8 value) => new Model(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelVariant8?(Model @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public Model(global::G.ModelVariant8? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// Excels at writing and complex tasks
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelVariant9? Value9 { get; init; }
#else
        public global::G.ModelVariant9? Value9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Model(global::G.ModelVariant9 value) => new Model(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelVariant9?(Model @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public Model(global::G.ModelVariant9? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// Excels at writing and complex tasks
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelVariant10? Value10 { get; init; }
#else
        public global::G.ModelVariant10? Value10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Model(global::G.ModelVariant10 value) => new Model(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelVariant10?(Model @this) => @this.Value10;

        /// <summary>
        /// 
        /// </summary>
        public Model(global::G.ModelVariant10? value)
        {
            Value10 = value;
        }

        /// <summary>
        /// Balance of speed and intelligence
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelVariant11? Value11 { get; init; }
#else
        public global::G.ModelVariant11? Value11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value11))]
#endif
        public bool IsValue11 => Value11 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Model(global::G.ModelVariant11 value) => new Model(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelVariant11?(Model @this) => @this.Value11;

        /// <summary>
        /// 
        /// </summary>
        public Model(global::G.ModelVariant11? value)
        {
            Value11 = value;
        }

        /// <summary>
        /// Our previous most fast and cost-effective
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelVariant12? Value12 { get; init; }
#else
        public global::G.ModelVariant12? Value12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value12))]
#endif
        public bool IsValue12 => Value12 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Model(global::G.ModelVariant12 value) => new Model(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelVariant12?(Model @this) => @this.Value12;

        /// <summary>
        /// 
        /// </summary>
        public Model(global::G.ModelVariant12? value)
        {
            Value12 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelVariant13? Value13 { get; init; }
#else
        public global::G.ModelVariant13? Value13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value13))]
#endif
        public bool IsValue13 => Value13 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Model(global::G.ModelVariant13 value) => new Model(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelVariant13?(Model @this) => @this.Value13;

        /// <summary>
        /// 
        /// </summary>
        public Model(global::G.ModelVariant13? value)
        {
            Value13 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelVariant14? Value14 { get; init; }
#else
        public global::G.ModelVariant14? Value14 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value14))]
#endif
        public bool IsValue14 => Value14 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Model(global::G.ModelVariant14 value) => new Model(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelVariant14?(Model @this) => @this.Value14;

        /// <summary>
        /// 
        /// </summary>
        public Model(global::G.ModelVariant14? value)
        {
            Value14 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Model(
            string? value1,
            global::G.ModelVariant2? value2,
            global::G.ModelVariant3? value3,
            global::G.ModelVariant4? value4,
            global::G.ModelVariant5? value5,
            global::G.ModelVariant6? value6,
            global::G.ModelVariant7? value7,
            global::G.ModelVariant8? value8,
            global::G.ModelVariant9? value9,
            global::G.ModelVariant10? value10,
            global::G.ModelVariant11? value11,
            global::G.ModelVariant12? value12,
            global::G.ModelVariant13? value13,
            global::G.ModelVariant14? value14
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
            Value8 = value8;
            Value9 = value9;
            Value10 = value10;
            Value11 = value11;
            Value12 = value12;
            Value13 = value13;
            Value14 = value14;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value14 as object ??
            Value13 as object ??
            Value12 as object ??
            Value11 as object ??
            Value10 as object ??
            Value9 as object ??
            Value8 as object ??
            Value7 as object ??
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4 || IsValue5 || IsValue6 || IsValue7 || IsValue8 || IsValue9 || IsValue10 || IsValue11 || IsValue12 || IsValue13 || IsValue14;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::G.ModelVariant2?, TResult>? value2 = null,
            global::System.Func<global::G.ModelVariant3?, TResult>? value3 = null,
            global::System.Func<global::G.ModelVariant4?, TResult>? value4 = null,
            global::System.Func<global::G.ModelVariant5?, TResult>? value5 = null,
            global::System.Func<global::G.ModelVariant6?, TResult>? value6 = null,
            global::System.Func<global::G.ModelVariant7?, TResult>? value7 = null,
            global::System.Func<global::G.ModelVariant8?, TResult>? value8 = null,
            global::System.Func<global::G.ModelVariant9?, TResult>? value9 = null,
            global::System.Func<global::G.ModelVariant10?, TResult>? value10 = null,
            global::System.Func<global::G.ModelVariant11?, TResult>? value11 = null,
            global::System.Func<global::G.ModelVariant12?, TResult>? value12 = null,
            global::System.Func<global::G.ModelVariant13?, TResult>? value13 = null,
            global::System.Func<global::G.ModelVariant14?, TResult>? value14 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
            }
            else if (IsValue7 && value7 != null)
            {
                return value7(Value7!);
            }
            else if (IsValue8 && value8 != null)
            {
                return value8(Value8!);
            }
            else if (IsValue9 && value9 != null)
            {
                return value9(Value9!);
            }
            else if (IsValue10 && value10 != null)
            {
                return value10(Value10!);
            }
            else if (IsValue11 && value11 != null)
            {
                return value11(Value11!);
            }
            else if (IsValue12 && value12 != null)
            {
                return value12(Value12!);
            }
            else if (IsValue13 && value13 != null)
            {
                return value13(Value13!);
            }
            else if (IsValue14 && value14 != null)
            {
                return value14(Value14!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::G.ModelVariant2?>? value2 = null,
            global::System.Action<global::G.ModelVariant3?>? value3 = null,
            global::System.Action<global::G.ModelVariant4?>? value4 = null,
            global::System.Action<global::G.ModelVariant5?>? value5 = null,
            global::System.Action<global::G.ModelVariant6?>? value6 = null,
            global::System.Action<global::G.ModelVariant7?>? value7 = null,
            global::System.Action<global::G.ModelVariant8?>? value8 = null,
            global::System.Action<global::G.ModelVariant9?>? value9 = null,
            global::System.Action<global::G.ModelVariant10?>? value10 = null,
            global::System.Action<global::G.ModelVariant11?>? value11 = null,
            global::System.Action<global::G.ModelVariant12?>? value12 = null,
            global::System.Action<global::G.ModelVariant13?>? value13 = null,
            global::System.Action<global::G.ModelVariant14?>? value14 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
            else if (IsValue7)
            {
                value7?.Invoke(Value7!);
            }
            else if (IsValue8)
            {
                value8?.Invoke(Value8!);
            }
            else if (IsValue9)
            {
                value9?.Invoke(Value9!);
            }
            else if (IsValue10)
            {
                value10?.Invoke(Value10!);
            }
            else if (IsValue11)
            {
                value11?.Invoke(Value11!);
            }
            else if (IsValue12)
            {
                value12?.Invoke(Value12!);
            }
            else if (IsValue13)
            {
                value13?.Invoke(Value13!);
            }
            else if (IsValue14)
            {
                value14?.Invoke(Value14!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(string),
                Value2,
                typeof(global::G.ModelVariant2),
                Value3,
                typeof(global::G.ModelVariant3),
                Value4,
                typeof(global::G.ModelVariant4),
                Value5,
                typeof(global::G.ModelVariant5),
                Value6,
                typeof(global::G.ModelVariant6),
                Value7,
                typeof(global::G.ModelVariant7),
                Value8,
                typeof(global::G.ModelVariant8),
                Value9,
                typeof(global::G.ModelVariant9),
                Value10,
                typeof(global::G.ModelVariant10),
                Value11,
                typeof(global::G.ModelVariant11),
                Value12,
                typeof(global::G.ModelVariant12),
                Value13,
                typeof(global::G.ModelVariant13),
                Value14,
                typeof(global::G.ModelVariant14),
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
        public bool Equals(Model other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelVariant3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelVariant4?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelVariant5?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelVariant6?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelVariant7?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelVariant8?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelVariant9?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelVariant10?>.Default.Equals(Value10, other.Value10) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelVariant11?>.Default.Equals(Value11, other.Value11) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelVariant12?>.Default.Equals(Value12, other.Value12) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelVariant13?>.Default.Equals(Value13, other.Value13) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelVariant14?>.Default.Equals(Value14, other.Value14) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Model obj1, Model obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Model>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Model obj1, Model obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Model o && Equals(o);
        }
    }
}
