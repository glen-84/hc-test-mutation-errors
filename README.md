# HC test mutation errors

When setting the default binding behaviour to `Explicit`, I see the following error:

> 1. Error while building type HotChocolate.Types.ErrorObjectType`1[[hc_test_mutation_errors.Types.MyError, hc-test-mutation-errors, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]. The runtime type hc_test_mutation_errors.Types.MyError does not defined a property `Message`

I've tried to explicitly bind the type in `MyErrorType.cs`, but it doesn't appear to be working.

`MyError` is used in the `MutationResult` in `Mutation.cs`.
