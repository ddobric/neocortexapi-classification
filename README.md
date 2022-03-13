Group Name: Team CodeCube

Team members: Alam Sher Khan (Matriculation number: 1387324), Aiman Zehra (Matriculation number: 1388996), Soundarya Talawai (Matriculation number: 1390133)

Project Description
1. Objective: Analyse Image Classification of MNIST Dataset
In the previous work at the university an Image Classification solution has been implemented. Our task is to implement a program that uses the existing solution and start a training of learning images. The image dataset which we have used in this project is MNIST Database images. Our task is to change various learning parameters and to find the best fit that shows image classification. Most important learning parameters are: Global/Local Inhibition, Potential Radius, Local Area Density and NumofActiveColumnsPerInArea. We have to demonstrate how these parameters influence the learning. Our code must provide the learning code and prediction code. After learning user should use your code and test the quality of learning. For example, the user after learning enter the image “table”. The prediction code provide a set of predicting results like: “Table – 87%, chair 7%, light - 3%”.

2. Our Approach
1 - To find the HTM Parameters which gives the best fit that shows image classification
We have changed various parameters Global/Local Inhibition, Potential Radius, Local Area Density between various images of MNIST datasets. After conducting various experiments we have been able to find the parameters at which we get the least overlapping in between micro and macro and thus the best correlation matrix.

For example: Capture

2 - To provide the prediction code
After we got the parameters which shows the best correlation matrix, we have added the code for predicting the images after learning phase.

Case1- We have entered an image which is somewhere similar to the input images(Dataset), and the prediction code will calculate the maximum percentage of similarity between the entered image and the input images of the label(Dataset)
Case2- We have entered and image which is completely different from the input images(Dataset), in this case the prediction code will direct a message as "Image is not similar to any of the input images"
The prediction code will calculate the Highest similarity in between the input images of the label(Dataset).
The prediction code will give the name of the label which is being predicted with the highest similarity.
Example
Case1 - When testing image is similar to the learning dataset
Testing Image

9_pic2

Learning Dataset

Capture

Output Result in Case 1

Capture

Case2 - When testing image is completely different from the learning dataset
Testing Image

Capture

Learning Dataset

Capture

Output Result in Case 2

Capture

3. Steps to setup the Learning and Prediction Code:
Step1 - (To setup input folder for learning/training of images)
Images must be copied in the following folder structure along with the application and the config json: (https://github.com/Alam-Sher-Khan/neocortexapi-classification/tree/Aiman/ImageClassification/ImageClassification/InputFolder)
Capture

The imagesets(MNIST) are stored inside "InputFolder/".
Capture

Each Imageset is stored inside a folder whose name is the set's label.
Capture

Step2 - (To setup image for prediction code)
Select an Image and give the location path of the image in the prediction code (https://github.com/Alam-Sher-Khan/neocortexapi-classification/blob/Aiman/ImageClassification/ImageClassification/Experiment.cs#L79)
Example: Capture

HTM setting of the project can be inputted to the program by means of a .json file (https://github.com/Alam-Sher-Khan/neocortexapi-classification/blob/Aiman/ImageClassification/ImageClassification/htmconfig.json) . Various experiments have been conducted with changes of parameters in the json file After running the code at the best HTM parameters obtained after experimenting in the learning phase, we can get the prediction status of any input image.
4. Working Process
Following steps are included in the processing of the training of images:

Binarization/Encoder:It is responsible for encoding the images in binary form after training of the images.(https://github.com/Alam-Sher-Khan/neocortexapi-classification/blob/Aiman/ImageClassification/ImageClassification/InputFolder/One/1_a1.txt)

Spatial Pooling: The essential function of spatial pooling is to form an SDR of the inputs. The output of the spatial pooler is as a binary vector, which represents the activation of columns in response to the current input.The SP consists of three phases, namely overlap, inhibition, and learning.

Learning Validation: The result of the learning of images will generate a matrix which will show the relation between the micro (correlation in between the images of same label) and macro (correlation in between the images of different label)

Example: Capture

Prediction Valiation: The prediction code added will help to find the precentage of similarity between th input image and the SDR's of the MNIST dataset, and thus predicting the label of the image having the highest similarity.
5. Goals Achieved
So far several experiments have been done to get the best correlation matrix in the learning phase and prediction code has been generated based on the initial analysis in the learning phase.

6. In-Progress
We are conducting more experiments to further analyse the effects of other HTM Parameters on learning of MNIST images.
We are working to create graphs from the data obtained from experiments.
We are working on prediction code to make the setup of input testing image path independent of the local machine.


