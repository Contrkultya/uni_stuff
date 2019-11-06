public class ArrayList {
    private int size;
    private int capacity;
    private int[] elements;

    public int getSize(){
        return this.size;
    }

    public void setSize(int size){
        this.size = size;
    }

    public int getCapacity(){
        return this.capacity;
    }


    public void setCapacity(int capacity) throws SizeGreaterThanCapacityException {
        if(capacity > this.elements.length) {
            this.capacity = capacity;
        }
        else {
            throw  new SizeGreaterThanCapacityException();
        }
    }


    public int[] getElements() {
        return elements;
    }

    public void setElements(int[] elements) throws SizeGreaterThanCapacityException{
        if(elements.length > capacity){
            throw new SizeGreaterThanCapacityException();
        }
        else {
            System.arraycopy(this.elements, 0, elements, 0, capacity);
        }
    }

    public ArrayList(int [] elements){
        this.elements = elements;
        this.size = elements.length;
        this.capacity = elements.length;
    }

    public ArrayList(int [] elements, int capacity) throws SizeGreaterThanCapacityException{
        this.elements = elements;
        this.size = elements.length;
        if(this.size < capacity) {
            throw new SizeGreaterThanCapacityException();
        }
        else {
            this.capacity = capacity;
        }
    }

    public ArrayList(){
        this.elements = new int[0];
        this.capacity = 0;
        this.size = 0;
    }


    public void append(int value){
        this.size++;
        increaseCapacity();
        this.elements[size - 1] = value;
    }

    public void insert(int value, int pos) throws SizeGreaterThanCapacityException {
        this.size++;
        increaseCapacity();
        int [] newArray = new int[capacity];
        System.arraycopy(this.elements, 0, newArray, 0, pos);
        newArray[pos] = value;
        System.arraycopy(this.elements, pos, newArray, pos + 1, capacity - pos);
        setElements(newArray);
    }

    public int getByIndex(int index) throws ArrayIndexOutOfBoundsException{
        return this.elements[index];
    }


    public void removeByIndex(int index) throws ArrayIndexOutOfBoundsException, SizeGreaterThanCapacityException {
        this.size--;
        int[] newArray = new int[capacity];
        System.arraycopy(this.elements, 0, newArray, 0, index);
        System.arraycopy(this.elements, index + 1, newArray, index, capacity - index);
        setElements(newArray);
    }

    public void increaseCapacity(){
        if(this.capacity <= this.size){
            this.capacity = (int) (this.capacity * 1.5);
            int[] newArray = new int[capacity];
            System.arraycopy(this.elements, 0, newArray, 0, this.elements.length);
            this.elements = newArray;
        }
    }



}


class SizeGreaterThanCapacityException extends Exception{

}
