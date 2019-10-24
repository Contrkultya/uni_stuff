import java.util.*;

// node class is the basic structure
// of each node present in the Huffman - tree.
class HuffmanNode {

    int data;
    char c;
    String code;

    HuffmanNode left;
    HuffmanNode right;

    static ArrayList<HuffmanNode> allElements= new ArrayList<HuffmanNode>();
}

// comparator class helps to compare the node
// on the basis of one of its attribute.
// Here we will be compared
// on the basis of data values of the nodes.
class MyComparator implements Comparator<HuffmanNode> {
    public int compare(HuffmanNode x, HuffmanNode y)
    {

        return x.data - y.data;
    }
}

class Huffman {

    // recursive function to print the
    // huffman-code through the tree traversal.
    // Here s is the huffman - code generated.
    private static void printCode(HuffmanNode root, String s)
    {

        // base case; if the left and right are null
        // then its a leaf node and we print
        // the code s generated by traversing the tree.
        if (root.left == null && root.right == null && Character.isLetter(root.c)) {

            // c is the character in the node
            System.out.println(root.c + ":" + s);
            root.code = s;
            HuffmanNode.allElements.add(root);
            return;
        }

        // if we go to left then add "0" to the code.
        // if we go to the right add"1" to the code.

        // recursive calls for left and
        // right sub-tree of the generated tree.
        printCode(root.left, s + "0");
        printCode(root.right, s + "1");
    }

    // main function
    public static void main(String[] args)
    {
        Scanner sca = new Scanner(System.in);
        System.out.println("Enter your string, plizki");
        String userInput = sca.nextLine();
        char[] inputCharAr = userInput.toCharArray();
        HashSet<Character> charsSet = new HashSet<Character>();
        for(char X: inputCharAr){
            charsSet.add(X); //filling the charSet with unique chars
        }
        ArrayList<Character> charsList = new ArrayList<Character>(charsSet); // making an arraylist coz there's no get() method in hashsets
        char [] charArray = new char[charsSet.size()];
        for (int i = 0; i < charArray.length; i++){
            charArray[i] = charsList.get(i);
        }
        // number of characters.
        int[] charFreq = new int[charsSet.size()];
        for (int i = 0; i < charArray.length; i++){
            for (int j = 0; j < inputCharAr.length; j++){
                if(charArray[i] == inputCharAr[j]){
                    charFreq[i]++;
                }
            }
        }


        // creating a priority queue q.
        // makes a min-priority queue(min-heap).
        PriorityQueue<HuffmanNode> q = new PriorityQueue<HuffmanNode>(charFreq.length, new MyComparator());

        for (int i = 0; i < charFreq.length; i++){
            // creating a Huffman node object
            // and add it to the priority queue.
            HuffmanNode hn = new HuffmanNode();

            hn.c = charArray[i];
            hn.data = charFreq[i];

            hn.left = null;
            hn.right = null;

            // add functions adds
            // the huffman node to the queue.
            q.add(hn);
        }

        // create a root node
        HuffmanNode root = null;

        // Here we will extract the two minimum value
        // from the heap each time until
        // its size reduces to 1, extract until
        // all the nodes are extracted.
        while (q.size() > 1) {

            // first min extract.
            HuffmanNode x = q.peek();
            q.poll();

            // second min extarct.
            HuffmanNode y = q.peek();
            q.poll();

            // new node f which is equal
            HuffmanNode f = new HuffmanNode();

            // to the sum of the frequency of the two nodes
            // assigning values to the f node.
            f.data = x.data + y.data;
            f.c = '-';

            // first extracted node as left child.
            f.left = x;

            // second extracted node as the right child.
            f.right = y;

            // marking the f node as the root node.
            root = f;

            // add this node to the priority-queue.
            q.add(f);
        }

        // print the codes by traversing the tree
        printCode(root, "");
        //the final string output:
        System.out.println("______________________________________________________________ \n");
        for(int i = 0 ; i < inputCharAr.length; i++){
            for(int j = 0; j < charArray.length; j++){
                if(inputCharAr[i] == inputCharAr[j]){
                    System.out.print(HuffmanNode.allElements.get(j).code);
                }
            }
        }
    }
}