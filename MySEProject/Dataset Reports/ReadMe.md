## Experiment Overview

#### Training Dataset:

For the simple shapes learning dataset, the images of Circle, Rectangle and Traingle are used which has the input dimensions of 64x64.

#### Experiment Results

For this dataset, the experiments are conducted on the following parameters and the results are recorded in the ExperimentReport.xlsx file along with the output.png images in OutputFolder

| Parameter       | Description         |
| ------------- |:-------------:|
| POTENTIAL_RADIUS      |Defines the radius in number of input cells visible to column cells. It is important to choose this value, so every input neuron is connected to at least a single column. |
| GLOBAL_INHIBITION      |If TRUE global inhibition algorithm will be used. If FALSE local inhibition algorithm will be used. |
| LOCAL_AREA_DENSITY      |Density of active columns inside of local inhibition radius. If set on value < 0, explicit number of active columns (NUM_ACTIVE_COLUMNS_PER_INH_AREA) will be used. |
| NUM_ACTIVE_COLUMNS_PER_INH_AREA     |An alternate way to control the density of the active columns. If this value is specified then LOCAL_AREA_DENSITY must be less than 0, and vice versa. |

After a good amount of experiments the experiment-35(potential radius - 30 localareadensity - 0.15) has given the best fit matrix.