## Experiment Overview

#### Training Dataset:

For the simple shapes learning dataset, the images of Circle, Square, Star, Rectangle and Traingle are used which has the input dimensions of 64x64 and 100x100.

Dataset GurunagSai has an input dimension of 64x64

Dataset Otovwerakpo has an input dimension of 100x100

Two diiferent set of datset are used to observe if the size of a datset would influence the result.

#### Experiment Results

For this dataset, the experiments are conducted on the following parameters and the results are recorded in the ExperimentReport.xlsx file along with the output.png (Dataset GurunagSai) and experiment.ng (Dataset Otovwerakpo) images in OutputFolder

| Parameter       | Description         |
| ------------- |:-------------:|
| POTENTIAL_RADIUS      |Defines the radius in number of input cells visible to column cells. It is important to choose this value, so every input neuron is connected to at least a single column. |
| GLOBAL_INHIBITION      |If TRUE global inhibition algorithm will be used. If FALSE local inhibition algorithm will be used. |
| LOCAL_AREA_DENSITY      |Density of active columns inside of local inhibition radius. If set on value < 0, explicit number of active columns (NUM_ACTIVE_COLUMNS_PER_INH_AREA) will be used. |
| NUM_ACTIVE_COLUMNS_PER_INH_AREA     |An alternate way to control the density of the active columns. If this value is specified then LOCAL_AREA_DENSITY must be less than 0, and vice versa. |

For Dataset GurunagSia (64x64): After a good amount of experiments, output-17.ng with a paramemters of potential radius 10 and localareadensity 0.3 gives the best results.

![output-17](https://user-images.githubusercontent.com/46021672/160385913-df6764f8-867b-4603-906e-f793c9122723.png)


For Dataset Otovwerakpo (100x100): After a good amount of experiments, experiment0025.ng with a paramemters of potential radius 30 and localareadensity 0.3 gives the best results.
![Expriment0025](https://user-images.githubusercontent.com/75277351/160253868-6844eac9-7d4f-429e-8dfd-6be8d5eb566b.JPG)

