This sample illustrate an issue between  ```<AnalysisModeSecurity>All</AnalysisModeSecurity>``` and dotnet_analyzer_diagnostic.category-Security.severity = error.


This rule was enabled via adding the AnalysisModeSecurity to all into the csproj file.

We also have a global config file which controls the severity of the different rules.

As per https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca5401
we've setup dotnet_analyzer_diagnostic.category-Security.severity = error into the global config file.

But the build still only generates a warning level :
_warning CA5401: Symmetric encryption uses non-defaul initialization vector, which could be potentially repeatable_