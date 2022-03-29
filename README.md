## **Project Description**

## 1. NeocortexApi Analyse Image Classification of MNIST Dataset
* Our First Objective is to examine the HTM parameters (lobal/Local Inhibition, Potential Radius, Local Area Density and NumofActiveColumnsPerInArea.) which results in the highest similarity for the image of same label/class and lowest similarity between images of different classes of MNIST (Modified National Institute of Standards and Technology) dataset.

* We also have to generate the prediction code for image classification so that after training, the system can classify any given testing image based on the similarity with the categories of training dataset.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
### What is MNIST Dataset?
The MNIST database (Modified National Institute of Standards and Technology database) is a large database of handwritten digits that is commonly used for training various image processing systems.The database is also widely used for training and testing in the field of machine learning.The MNIST database contains 60,000 training images and 10,000 testing images.

In this project we used MNIST images of 28x28 pixels obtained from https://github.com/ddobric/neocortexapi/tree/master/source/UnitTestsProject/MnistPng28x28_smallerdataset

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
## 2. **Project Process**

The goal of this project is to implement a program that uses the existing solution as a library and find the spatial pooler parameter values which influence the learning of images and result in the high similarity of micro correlation matrix and can also predict any input image based on the learning in HTM.
When started the application will load images and start the training process. The training process runs in following steps.

**(1) Convert The Images to binary array via binarization**: 
The Binarization Library was developed as an open source project at Daenet.The current implementation uses a color threshold of 200 for every color in a 8bit-RGB scale.It is responsible for encoding the images in binary form after training of the images.(https://github.com/Alam-Sher-Khan/neocortexapi-classification/blob/Alam/ImageClassification/ImageClassification/InputFolder/One/1_a1.txt)

![Capture](https://user-images.githubusercontent.com/93146590/160106040-263b7989-4a64-4556-aeb8-313cc8e08147.JPG)

**(2) Learn spatial patterns stored in images with the Spatial Pooler(SP)**: 
SP first iterates through all images until the stable state is entered. SP iterate through all the images as it learns. The essential function of spatial pooling is to form an SDR of the inputs. The output of the spatial pooler is as a binary vector, which represents the activation of columns in response to the current input.The SP consists of three phases, namely overlap, inhibition, and learning.

**(3) Validation of SP Learning for different set of images**: 
The result of the learning of images will generate a matrix which will show the relation between the micro (correlation in between the images of same label) and macro (correlation in between the images of different label).The last set of Sparse Density Representations (SDRs), the output of Spatial Pooler(SP) for each binarized image were saved for correlation validation.
There are 2 types of correlation which are defined as follow: 

**Micro Correlation**: Maximum/Average/Minimum correlation in similar bit percent of all images' SDRs which respect to each another in the same label.

**Macro Correlation**: Maximum/Average/Minimum correlation in similar bit percent of all images' SDRs with images from 2 different labels.
The results of the two correlation are printed in the command prompt when executing the code
 
**(4) Prediction Valiation**: 
The prediction code added will help to find the precentage of similarity between th input image and the SDR's of the MNIST dataset, and thus predicting the label of the image having the highest similarity. After we got the parameters which shows the highest similarity correlation matrix, we added the code for predicting the testing images after learning phase.
1) Case1- We entered an image in the TestFolder which is from the same label of training dataset, and the prediction code will calculate the maximum percentage of similarity between the testing image and the training images.
2) Case2- We entered a testng image which is completely different from the training images(Dataset), in this case the prediction code will direct a message as "Image is not similar to any of the input images"
3) The prediction code will calculate the Highest similarity between the testing images and the trainign images of the label(Dataset).
4) The prediction code will give the name of the label which is being predicted with the highest similarity.

**Below is the link of the prediction code implemented :** 
https://github.com/Alam-Sher-Khan/neocortexapi-classification/blob/4faab23d94c1412130090b1a6281362441010a7a/MySEProject/ImageClassification/Experiment.cs#L97

**Workflow of the learning and prediction of MNIST images**
![image](https://user-images.githubusercontent.com/93146590/160408643-862ebf41-e4ba-4fe8-b404-4841cb724d1d.png)

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
## 3. How to use the classifier?
### Step1 - To setup input folder for learning/training of images
* Images must be copied in the following folder structure along with the application and the config json: https://github.com/Alam-Sher-Khan/neocortexapi-classification/tree/main/MySEProject/ImageClassification/ImageClassification/InputFolder

![image](https://user-images.githubusercontent.com/93146590/160149722-9f3fe332-e379-412e-848b-0669f3315967.png)


**The imagesets(MNIST) are stored inside "InputFolder/".**

![image](https://user-images.githubusercontent.com/93146590/160150110-77ac199c-2096-4cef-8c38-785efc0ae7f1.png)

**Each Imageset is stored inside a folder whose name is the set's label.**
![image](https://user-images.githubusercontent.com/93146590/160151966-0759b25e-3c05-42db-bfd1-c562bb295f74.png)


### Step2 - To setup Test folder for testing the prediction of images
Testing images must be copied in the following folder structure

![Test Folder Structure](https://user-images.githubusercontent.com/93139817/160196610-23590fc5-bfcb-490a-ab21-92079c307c8b.PNG)

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 4. Goals Achieved

* Experiments with different variations of local area density, potential radius, local/global inhibition have been done to get the correlation matrix which results in high micro similarity and low macro similarity.
* The experimental data and graphical analysis can be found from the excel file in the link: https://github.com/Alam-Sher-Khan/neocortexapi-classification/tree/main/MySEProject/Documentation/Graphs%20and%20Analysis
* We have developed the prediction code which is capable to classify the image wih high accuracy.
* In case of MNIST images there is still a certain level of similarity between images of different labels, to solve this issue in predictions, we used **Similarity Threshold Criteria** whose value is selected based on HTM parameters in htmconfig.json file.
* **Our prediction code is efficient as it can predict any number of images at the same execution of the code which saves time.**
* Our **prediction code automatically fetches the absolute path of the testing images in the TestFolder** so it does not require the paths to be entered manually in the code.

![Capture](https://user-images.githubusercontent.com/93146590/160189988-db37a83d-132d-41ca-a435-8e2d6f9c20ef.JPG)

## 5. In-Progress
* We are conducting more experiments to further analyse the effects of other HTM Parameters on learning of MNIST images.
