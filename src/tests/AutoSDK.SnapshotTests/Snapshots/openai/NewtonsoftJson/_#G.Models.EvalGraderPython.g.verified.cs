//HintName: G.Models.EvalGraderPython.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EvalGraderPython : global::System.IEquatable<EvalGraderPython>
    {
        /// <summary>
        /// A PythonGrader object that runs a python script on the input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraderPython? PythonGrader { get; init; }
#else
        public global::G.GraderPython? PythonGrader { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PythonGrader))]
#endif
        public bool IsPythonGrader => PythonGrader != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EvalGraderPythonVariant2? Value2 { get; init; }
#else
        public global::G.EvalGraderPythonVariant2? Value2 { get; }
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
        public static implicit operator EvalGraderPython(global::G.GraderPython value) => new EvalGraderPython((global::G.GraderPython?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraderPython?(EvalGraderPython @this) => @this.PythonGrader;

        /// <summary>
        /// 
        /// </summary>
        public EvalGraderPython(global::G.GraderPython? value)
        {
            PythonGrader = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalGraderPython(global::G.EvalGraderPythonVariant2 value) => new EvalGraderPython((global::G.EvalGraderPythonVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EvalGraderPythonVariant2?(EvalGraderPython @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public EvalGraderPython(global::G.EvalGraderPythonVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EvalGraderPython(
            global::G.GraderPython? pythonGrader,
            global::G.EvalGraderPythonVariant2? value2
            )
        {
            PythonGrader = pythonGrader;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            PythonGrader as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PythonGrader?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPythonGrader && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GraderPython?, TResult>? pythonGrader = null,
            global::System.Func<global::G.EvalGraderPythonVariant2?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPythonGrader && pythonGrader != null)
            {
                return pythonGrader(PythonGrader!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GraderPython?>? pythonGrader = null,
            global::System.Action<global::G.EvalGraderPythonVariant2?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPythonGrader)
            {
                pythonGrader?.Invoke(PythonGrader!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PythonGrader,
                typeof(global::G.GraderPython),
                Value2,
                typeof(global::G.EvalGraderPythonVariant2),
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
        public bool Equals(EvalGraderPython other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GraderPython?>.Default.Equals(PythonGrader, other.PythonGrader) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EvalGraderPythonVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EvalGraderPython obj1, EvalGraderPython obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvalGraderPython>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EvalGraderPython obj1, EvalGraderPython obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvalGraderPython o && Equals(o);
        }
    }
}
