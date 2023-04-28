# Alza.ResultTypes

## OneOf

|                 Method |      Mean |     Error |    StdDev |
|----------------------- |----------:|----------:|----------:|
|          OneOfCreation |  5.837 ns | 0.0554 ns | 0.0491 ns |
| OneOfCreationException | 12.856 ns | 0.1129 ns | 0.1001 ns |
|           OneOfGetUser | 19.023 ns | 0.0527 ns | 0.0493 ns |
|      OneOfGetException | 29.435 ns | 0.1142 ns | 0.0954 ns |

## Vanilla

|                   Method |         Mean |      Error |     StdDev |       Median |
|------------------------- |-------------:|-----------:|-----------:|-------------:|
|          VanillaCreation |     5.800 ns |  0.1416 ns |  0.1985 ns |     5.693 ns |
| VanillaCreationException |           NA |         NA |         NA |           NA |
|           VanillaGetUser |    13.804 ns |  0.0693 ns |  0.0649 ns |    13.822 ns |
|      VanillaGetException | 9,483.584 ns | 38.9651 ns | 36.4480 ns | 9,489.291 ns |

## Result Type

|                      Method |      Mean |     Error |    StdDev |
|---------------------------- |----------:|----------:|----------:|
|          ResultTypeCreation | 14.675 ns | 0.0669 ns | 0.0626 ns |
| ResultTypeCreationException |  8.607 ns | 0.0283 ns | 0.0251 ns |
|           ResultTypeGetUser | 14.470 ns | 0.0779 ns | 0.0729 ns |
|      ResultTypeGetException |  8.652 ns | 0.0298 ns | 0.0279 ns |

