# Project:	Analyse Image Classification on Simple Shapes

## Project Description
Previously the Image Classification solution has been implemented. Our task is to implement a program that uses the exsisting solution as a library and start a training of learning shapes. Our group has used the simple shapes such as Circle, Rectangle, Triangle and Star images for training the model.

Our task is to change various learning parameters and to find the best fit that shows image classification. Most important learning parameters are: Global/Local Inhibition, Potential Radius, Local Area Density and NumofActiveColumnsPerInArea and demonstrate how these parameters influence learning. 

We must provide the learning code and possibly some prediction code. After learning user should use your code and test the quality of learning. For example, the user after learning enter the image “Circle”. The prediction code provide a set of predicting results like: “Circle – 73%, Rectangle 14%, Triangle - 11%”.

 ## Setup for Learning and Prediction
 
 ### Step-1: Prepare the program's directory for learning Shapes
 
 Create a new folder "InputFolder/" in the project directory and the imagesets which are used to train the model are stored in it.
 
!["InputFolder/" with the shapes to train](https://user-images.githubusercontent.com/46021672/158034659-5e2c7221-f513-4c6d-b59b-5e78a8107aa6.png)

 Each Imageset is stored inside a folder whose name is the set's label.
 
![shape images](https://user-images.githubusercontent.com/46021672/158034776-5de660bd-5576-4f4f-a115-84ea57904453.png)

### Step-2: Prepare the program's directory for Prediction Images.
 
 Create a new folder "PredictInputFolder/" in the project directory and the Prediction Images are stored in it, where the prediction extracts the images from this directory to perform the shape prediction with the help of trained dataset. The prediction code is able to get the multiple images for prediction and displays the similarity output respectivly

 !["PredictInputFolder/" with the images to be predicted](https://user-images.githubusercontent.com/46021672/158034865-d6fe12bf-bf22-452a-8c91-d783d784660e.png)
 
 ![Prediction Directory code](https://user-images.githubusercontent.com/46021672/158034961-975f4150-229b-49a6-8103-afc2969638c9.png)

## Tasks

### Task 1: To change the various learning parameters and find the best fit that shows image classification. 

The following parameters have been changed for the trained image dataset of simple shapes. 

| Parameter       | Description         |
| ------------- |:-------------:|
| POTENTIAL_RADIUS      |Defines the radius in number of input cells visible to column cells. It is important to choose this value, so every input neuron is connected to at least a single column. |
| GLOBAL_INHIBITION      |If TRUE global inhibition algorithm will be used. If FALSE local inhibition algorithm will be used. |
| LOCAL_AREA_DENSITY      |Density of active columns inside of local inhibition radius. If set on value < 0, explicit number of active columns (NUM_ACTIVE_COLUMNS_PER_INH_AREA) will be used. |
| NUM_ACTIVE_COLUMNS_PER_INH_AREA     |An alternate way to control the density of the active columns. If this value is specified then LOCAL_AREA_DENSITY must be less than 0, and vice versa. |

After experimenting the learning dataset with the various parameters, we were able to find the best corelation matrix that shows image classification for simple shapes.

![correlation matrix](https://user-images.githubusercontent.com/46021672/158035925-f3685ac9-3e79-4602-88ed-7146ba192e5f.png)

### Task 2: Code for Image Prediction. 

1. After the learning process, The prediction images are extracted from the "PredictInputFolder/".(Multiple images can be provided as input for the prediction where the code is able to loop between them and display the similarity results respectively)
2. The images are encoded and input pattern is learned.
3. The Prediction method compares the predict image SDR with the trained image SDR's and caluclates the average percentage of similarity for a shape.
4. The Prediction code will display the average percentage between the input predict image and trained shapes.

![prediction result](https://user-images.githubusercontent.com/46021672/158036528-f72fdfc6-607c-4046-8397-2a29e971613d.png)

## Progress of the project

1. Objective-1: We have conducted several experiments with the parameters for the training phase, we need to conduct more experiments for getting the best correlation matrix for the simple shapes.
2. Objective-2: Implemented prediction code, due to the less accuracy of the trained model, the prediction values for the images similar to the dataset is less similar. Need to improve the accuracy and code.
