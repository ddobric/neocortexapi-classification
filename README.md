Group Name: Team CodeCube

# **Project Description**

## 1. **Objective: Analyse Image Classification of MNIST Dataset**
In the previous work at the university an Image Classification solution has been implemented. Our task is to implement a program that uses the existing solution and start a training of learning images. The image dataset which we have used in this project is MNIST Database images. Our task is to change various learning parameters and to find the best fit that shows image classification. Most important learning parameters are: Global/Local Inhibition, Potential Radius, Local Area Density and NumofActiveColumnsPerInArea.
We have to demonstrate how these parameters influence the learning. Our code must provide the learning code and prediction code. After learning user should use your code and test the quality of learning. For example, the user after learning enter the image “table”. The prediction code provide a set of predicting results like: “Table – 87%, chair 7%, light - 3%”.

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 2. **Our Approach**

### 1 - To find the HTM Parameters which gives the best fit that shows image classification
We have changed various parameters Global/Local Inhibition, Potential Radius, Local Area Density between various images of MNIST datasets. After conducting various experiments we have been able to find the parameters at which we get the least overlapping in between micro and macro and thus the best correlation matrix.

 For example:
![Capture](https://user-images.githubusercontent.com/93146590/157971089-95cce4d0-f8c8-4332-804e-769f84ac9611.JPG)

### 2 - To provide the prediction code
After we got the parameters which shows the best correlation matrix, we have added the code for predicting the images after learning phase.
1) Case1- We have entered an image which is somewhere similar to the input images(Dataset), and the prediction code will calculate the maximum percentage of similarity between the entered image and the input images of the label(Dataset)
2) Case2- We have entered and image which is completely different from the input images(Dataset), in this case the prediction code will direct a message as "Image is not similar to any of the input images"
3) The prediction code will calculate the Highest similarity in between the input images of the label(Dataset).
4) The prediction code will give the name of the label which is being predicted with the highest similarity.

### Example

### **Case1** - When testing image is similar to the learning dataset

**Testing Image**

![9_pic2](https://user-images.githubusercontent.com/93146590/158055870-5eefaedf-63bb-48e3-9f5c-f9f71b5f050b.png)

**Learning Dataset**

![Capture](https://user-images.githubusercontent.com/93146590/158055986-143d49d7-793a-4b1f-9cb0-907fea8865a5.JPG)

**Output Result in Case 1**

![Capture](https://user-images.githubusercontent.com/93146590/158058910-52c1de99-bc2e-45ee-8b6d-5f54a9ee2cd0.JPG)

### **Case2** - When testing image is completely different from the learning dataset

**Testing Image**

![Capture](https://user-images.githubusercontent.com/93146590/158060200-d458aae5-4642-478e-b36e-99c098d82588.JPG)

**Learning Dataset**

![Capture](https://user-images.githubusercontent.com/93146590/158055986-143d49d7-793a-4b1f-9cb0-907fea8865a5.JPG)

**Output Result in Case 2**

![Capture](https://user-images.githubusercontent.com/93146590/158025416-cb7330c9-666b-47a2-802d-ef4c5f967e09.JPG)

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
## 3. Steps to setup the Learning and Prediction Code:
### Step1 - (To setup input folder for learning/training of images)
* Images must be copied in the following folder structure along with the application and the config json: (https://github.com/Alam-Sher-Khan/neocortexapi-classification/tree/Aiman/ImageClassification/ImageClassification/InputFolder)

![Capture](https://user-images.githubusercontent.com/93146590/158056620-58a8ea39-6be9-473e-b7e5-ad398e2504e5.JPG)

* The imagesets(MNIST) are stored inside "InputFolder/".

![Capture](https://user-images.githubusercontent.com/93146590/157983651-dd5b38c8-463a-4310-b118-3b5e2df73f06.JPG)

* Each Imageset is stored inside a folder whose name is the set's label.

![Capture](https://user-images.githubusercontent.com/93146590/157983987-0cdfe35a-811e-49f2-b580-ec515889c2a4.JPG)

### Step2 - (To setup image for prediction code)
* Select an Image and give the location path of the image in the prediction code (https://github.com/Alam-Sher-Khan/neocortexapi-classification/blob/Aiman/ImageClassification/ImageClassification/Experiment.cs#L79)

Example:
![Capture](https://user-images.githubusercontent.com/93146590/158025162-08efce1d-ac9d-49f0-b12b-b273312cd706.JPG)

* HTM setting of the project can be inputted to the program by means of a .json file (https://github.com/Alam-Sher-Khan/neocortexapi-classification/blob/Aiman/ImageClassification/ImageClassification/htmconfig.json) . Various experiments have been conducted with changes of parameters in the json file
After running the code at the best HTM parameters obtained after experimenting in the learning phase, we can get the prediction status of any input image.

## 4. Working Process
Following steps are included in the processing of the training of images:

1) Binarization/Encoder:It is responsible for encoding the images in binary form after training of the images.(https://github.com/Alam-Sher-Khan/neocortexapi-classification/blob/Aiman/ImageClassification/ImageClassification/InputFolder/One/1_a1.txt)

2) Spatial Pooling: The essential function of spatial pooling is to form an SDR of the inputs. The output of the spatial pooler is as a binary vector, which represents the activation of columns in response to the current input.The SP consists of three phases, namely overlap, inhibition, and learning.

3) Learning Validation: The result of the learning of images will generate a matrix which will show the relation between the micro (correlation in between the images of same label) and macro (correlation in between the images of different label)

Example:
![Capture](https://user-images.githubusercontent.com/93146590/158057244-268ce79a-2859-4d44-b534-49d13fe5c935.JPG)

4) Prediction Valiation: The prediction code added will help to find the precentage of similarity between th input image and the SDR's of the MNIST dataset, and thus predicting the label of the image having the highest similarity.


## 5. Goals Achieved
So far several experiments have been done to get the best correlation matrix in the learning phase and prediction code has been generated based on the initial analysis in the learning phase.

## 6. In-Progress
* We are conducting more experiments to further analyse the effects of other HTM Parameters on learning of MNIST images.
* We are working to create graphs from the data obtained from experiments.
* We are working on prediction code to make the setup of input testing image path independent of the local machine.
