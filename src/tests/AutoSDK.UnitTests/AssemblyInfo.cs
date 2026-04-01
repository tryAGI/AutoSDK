using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Workers = 10, Scope = ExecutionScope.MethodLevel)]
