using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class FoodQueue
    {
        int front;
        int rear;

        FoodItem[] turnTable;

        public FoodQueue() {
            front = -1;
            rear = -1;
            turnTable = new FoodItem[20];
        }

        public void enqueue(FoodItem item) {
            //check if the queue is full
            if (rear == turnTable.Length - 1 && front == 0 || rear == front - 1) {
                //array is full
                Console.WriteLine("Queue full, can not add item!");
                return;
            }
            //we can add something to the array so we need to figure out where it should be added
            if (rear == -1)
            {
                //this is the first element so we need to set front and rear to the same spot
                front = 0;
                rear = 0;
                turnTable[rear] = item;
            }
            else if (rear == turnTable.Length - 1 && front != 0)
            {
                //the last element of the array is filled so we need to move to the front
                rear = 0;
                turnTable[rear] = item;
            }
            else {
                //the rear index is somewhere in the middle of the array so we just need to increase it
                rear++;
                turnTable[rear] = item;
            }
        }

        public FoodItem dequeue() {
            FoodItem item = null;
            //check if array is empty
            if (front == -1)
            {
                Console.WriteLine("Queue is empty!");
                return item;
            }
            //there is an item so what do we do to the front index?
            item = turnTable[front];
            if (front == rear)
            {
                //there was only one element in the array, so we need to set the indices to the empty state
                item = turnTable[front];
                front = -1;
                rear = -1;
            }
            else if (front == turnTable.Length - 1)
            {
                //the element we grabbeed was at the end of the array so we need to loop the index around to the start
                front = 0;
            }
            else {
                //the index is somewhere in the middle so we just increase it by one
                front++;
            }
            return item;
        }

        public double averageCalories() {
            int sum = 0;
            int count = 0;
            foreach (FoodItem fi in turnTable) {
                if (fi == null) continue;
                sum += fi.getCalories();
                count++;
            }
            return (double)sum / (double)count;
            
        }

        public FoodItem findMostCalories() {
            int mostCalories = 0;
            int biggestIndex = -1;
            for (int i = 0; i < turnTable.Length; i++)
            {
                if (turnTable[i] == null) continue;
                int cals = turnTable[i].getCalories();
                int servs = turnTable[i].getServings();
                if(cals * servs > mostCalories)
                {
                    biggestIndex = i;
                }
            }
            return turnTable[biggestIndex];
        }

        public FoodItem peek() {
            FoodItem item = null;
            if (front == -1) {
                return item;
            }
            return turnTable[front];

        }
    }
}
