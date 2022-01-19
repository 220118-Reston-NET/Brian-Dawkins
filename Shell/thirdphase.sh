# Terminal Menu Exercise 
# Fast Food Model 

#Main Menu

echo "Welcome to the Burger Joint!"
echo What would you like?
echo 1 Burger
echo 2 Fries
echo 3 Combo
echo "Everything comes with a drink!"
echo Enter number of what you would like
read ans

if [ "$ans" == "1" ]
then 
echo Great choice!
echo Would you like all toppings or no toppings?
echo 1 All
echo 2 None
read ans1
fi

if [ "$ans1" == "1" ]
then 
echo "Great choice! Your burger will be ready shortly!"
fi
if [ "$ans1" == "2" ] 
then
echo "Great choice! Your burger will be ready shortly!"
fi


if [ "$ans" == "2" ]
then 
echo "Great Choice!"
echo Would you like Cajun or plain?
echo 1 Cajun
echo 2 Plain
read ans2
fi

if [ "$ans2" == "1" ]
then
echo "Great choice! Your fries will be ready shortly!"
fi
if [ "ans2" == "2" ]
then
echo "Great choice! Your fries will be ready shortly!"
fi

if [ "$ans" == "3" ]
then 
echo Great choice! What combo would you like?
echo 1 All topping Burger with cajun fries?
echo 2 All topping Burger with plain fries?
echo 3 No topping Burger with cajun fries?
echo 4 No topping Burger with plain fries?
read ans3
fi

if [ "$ans3" == "1" ]
then 
echo "Great choice! Your combo is on the way!"
else 
echo "Great choice! Your combo is on the way!"
fi



