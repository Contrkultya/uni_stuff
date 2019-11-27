import java.util.*;

public class Search {
    private int size;
    private ArrayList<Integer> array = new ArrayList<>();
    private int needle;

    public int getSize() {
        return this.size;
    }

    public ArrayList<Integer> getArray(){
        return this.array;
    }

    public Search(int size){
        this.size = size;
        for(int i = 0 ; i < size; i++){
            array.add(new Random().nextInt(20000));
        }
        this.needle = array.get(new Random().nextInt(size));
    }



    //linear search

    public int linearSearch(){
        for(int i = 0; i < this.size; i++){
            if(this.array.get(i) == this.needle){
                return this.array.get(i);
            }
        }
        return -1;
    }
    //binary search

    public int binarySearch(){
        array.sort(Integer::compareTo);
        int left = -1;
        int right = this.size - 1;
        while(left < right - 1) {
            int middle = (left + right) / 2;
            if((this.array.get(middle)) < (this.needle)){
                left = middle;
            }
            else{
                right = middle;
            }
        }
        return  right;
    }

    //Интерполяционный поиск

    public int interpolationalSearch(){
        this.array.sort(Integer::compareTo);
        int left = 0;
        int right = this.size - 1;

        while(this.array.get(left) < this.needle && this.needle < this.array.get(right)){
            int middle = left + ((this.needle - this.array.get(left)) * (right - left) / (this.array.get(right) - this.array.get(left)));
            if((this.array.get(middle)) < (this.needle)){
                left = middle++;
            }
            else{
                if((this.array.get(left)) > (this.needle)){
                    right = middle--;
                }
                else{
                    return middle;
                }
            }

            if(this.array.get(left) == this.needle) {
                return  left;
            }
            if(this.array.get(right) == this.needle) {
                return right;
            }
        }
        return  -1;
    }


}
