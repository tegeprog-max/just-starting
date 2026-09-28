converting a value turns it possible to be the convertion itself, it will be like:

double a  = 3.14;
int b = Convert.ToInt32(a);

so it will return the first value before (.) but instead of fully converting it will keep ur original type bc a convertion only can be applied when the value converting is being used,ex:

A will keep it double.
B will convert it in int but A keeps it double.