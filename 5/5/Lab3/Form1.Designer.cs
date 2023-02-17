namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Rect_create = new System.Windows.Forms.Button();
            this.Sq_create = new System.Windows.Forms.Button();
            this.El_create = new System.Windows.Forms.Button();
            this.Circle_create = new System.Windows.Forms.Button();
            this.rect_x = new System.Windows.Forms.TextBox();
            this.rect_y = new System.Windows.Forms.TextBox();
            this.rect_w = new System.Windows.Forms.TextBox();
            this.rect_h = new System.Windows.Forms.TextBox();
            this.sq_x = new System.Windows.Forms.TextBox();
            this.sq_y = new System.Windows.Forms.TextBox();
            this.sq_w = new System.Windows.Forms.TextBox();
            this.el_x = new System.Windows.Forms.TextBox();
            this.el_y = new System.Windows.Forms.TextBox();
            this.el_r1 = new System.Windows.Forms.TextBox();
            this.el_r2 = new System.Windows.Forms.TextBox();
            this.circ_x = new System.Windows.Forms.TextBox();
            this.circ_y = new System.Windows.Forms.TextBox();
            this.circ_r = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.figuresListBox = new System.Windows.Forms.ListBox();
            this.move_button = new System.Windows.Forms.Button();
            this.move_x = new System.Windows.Forms.TextBox();
            this.move_y = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.c_rect_button = new System.Windows.Forms.Button();
            this.c_sq_button = new System.Windows.Forms.Button();
            this.c_ellipse_button = new System.Windows.Forms.Button();
            this.c_circle_button = new System.Windows.Forms.Button();
            this.Polygon_create = new System.Windows.Forms.Button();
            this.Triangle_create = new System.Windows.Forms.Button();
            this.Cat_create = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cat_y = new System.Windows.Forms.TextBox();
            this.cat_x = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.star_h = new System.Windows.Forms.TextBox();
            this.star_w = new System.Windows.Forms.TextBox();
            this.star_y = new System.Windows.Forms.TextBox();
            this.star_x = new System.Windows.Forms.TextBox();
            this.Star_create = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.olymp_h = new System.Windows.Forms.TextBox();
            this.olymp_w = new System.Windows.Forms.TextBox();
            this.olymp_y = new System.Windows.Forms.TextBox();
            this.olymp_x = new System.Windows.Forms.TextBox();
            this.Olymp_create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Change.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 541);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Rect_create
            // 
            this.Rect_create.Location = new System.Drawing.Point(679, 3);
            this.Rect_create.Name = "Rect_create";
            this.Rect_create.Size = new System.Drawing.Size(130, 45);
            this.Rect_create.TabIndex = 1;
            this.Rect_create.Text = "create rectangle";
            this.Rect_create.UseVisualStyleBackColor = true;
            this.Rect_create.Click += new System.EventHandler(this.Rect_create_Click);
            // 
            // Sq_create
            // 
            this.Sq_create.Location = new System.Drawing.Point(833, 3);
            this.Sq_create.Name = "Sq_create";
            this.Sq_create.Size = new System.Drawing.Size(130, 45);
            this.Sq_create.TabIndex = 2;
            this.Sq_create.Text = "Create square";
            this.Sq_create.UseVisualStyleBackColor = true;
            this.Sq_create.Click += new System.EventHandler(this.Sq_create_Click);
            // 
            // El_create
            // 
            this.El_create.Location = new System.Drawing.Point(994, 3);
            this.El_create.Name = "El_create";
            this.El_create.Size = new System.Drawing.Size(130, 45);
            this.El_create.TabIndex = 3;
            this.El_create.Text = "create ellipse";
            this.El_create.UseVisualStyleBackColor = true;
            this.El_create.Click += new System.EventHandler(this.El_create_Click);
            // 
            // Circle_create
            // 
            this.Circle_create.Location = new System.Drawing.Point(1143, 3);
            this.Circle_create.Name = "Circle_create";
            this.Circle_create.Size = new System.Drawing.Size(130, 45);
            this.Circle_create.TabIndex = 4;
            this.Circle_create.Text = "create circle";
            this.Circle_create.UseVisualStyleBackColor = true;
            this.Circle_create.Click += new System.EventHandler(this.Circle_create_Click);
            // 
            // rect_x
            // 
            this.rect_x.Location = new System.Drawing.Point(718, 51);
            this.rect_x.Name = "rect_x";
            this.rect_x.Size = new System.Drawing.Size(91, 22);
            this.rect_x.TabIndex = 5;
            // 
            // rect_y
            // 
            this.rect_y.Location = new System.Drawing.Point(718, 79);
            this.rect_y.Name = "rect_y";
            this.rect_y.Size = new System.Drawing.Size(91, 22);
            this.rect_y.TabIndex = 6;
            // 
            // rect_w
            // 
            this.rect_w.Location = new System.Drawing.Point(718, 107);
            this.rect_w.Name = "rect_w";
            this.rect_w.Size = new System.Drawing.Size(91, 22);
            this.rect_w.TabIndex = 7;
            // 
            // rect_h
            // 
            this.rect_h.Location = new System.Drawing.Point(718, 135);
            this.rect_h.Name = "rect_h";
            this.rect_h.Size = new System.Drawing.Size(91, 22);
            this.rect_h.TabIndex = 8;
            // 
            // sq_x
            // 
            this.sq_x.Location = new System.Drawing.Point(879, 51);
            this.sq_x.Name = "sq_x";
            this.sq_x.Size = new System.Drawing.Size(84, 22);
            this.sq_x.TabIndex = 9;
            // 
            // sq_y
            // 
            this.sq_y.Location = new System.Drawing.Point(879, 79);
            this.sq_y.Name = "sq_y";
            this.sq_y.Size = new System.Drawing.Size(84, 22);
            this.sq_y.TabIndex = 10;
            // 
            // sq_w
            // 
            this.sq_w.Location = new System.Drawing.Point(879, 111);
            this.sq_w.Name = "sq_w";
            this.sq_w.Size = new System.Drawing.Size(84, 22);
            this.sq_w.TabIndex = 11;
            // 
            // el_x
            // 
            this.el_x.Location = new System.Drawing.Point(1042, 51);
            this.el_x.Name = "el_x";
            this.el_x.Size = new System.Drawing.Size(82, 22);
            this.el_x.TabIndex = 12;
            // 
            // el_y
            // 
            this.el_y.Location = new System.Drawing.Point(1042, 79);
            this.el_y.Name = "el_y";
            this.el_y.Size = new System.Drawing.Size(82, 22);
            this.el_y.TabIndex = 13;
            // 
            // el_r1
            // 
            this.el_r1.Location = new System.Drawing.Point(1042, 107);
            this.el_r1.Name = "el_r1";
            this.el_r1.Size = new System.Drawing.Size(82, 22);
            this.el_r1.TabIndex = 14;
            // 
            // el_r2
            // 
            this.el_r2.Location = new System.Drawing.Point(1042, 135);
            this.el_r2.Name = "el_r2";
            this.el_r2.Size = new System.Drawing.Size(82, 22);
            this.el_r2.TabIndex = 15;
            // 
            // circ_x
            // 
            this.circ_x.Location = new System.Drawing.Point(1180, 51);
            this.circ_x.Name = "circ_x";
            this.circ_x.Size = new System.Drawing.Size(93, 22);
            this.circ_x.TabIndex = 16;
            // 
            // circ_y
            // 
            this.circ_y.Location = new System.Drawing.Point(1180, 79);
            this.circ_y.Name = "circ_y";
            this.circ_y.Size = new System.Drawing.Size(93, 22);
            this.circ_y.TabIndex = 17;
            // 
            // circ_r
            // 
            this.circ_r.Location = new System.Drawing.Point(1180, 107);
            this.circ_r.Name = "circ_r";
            this.circ_r.Size = new System.Drawing.Size(93, 22);
            this.circ_r.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(680, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(837, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(994, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1142, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(680, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(837, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(994, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1142, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(680, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "W:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(837, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "W:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(680, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "H:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(994, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "R1:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(994, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "R2:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(1143, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 25);
            this.label14.TabIndex = 32;
            this.label14.Text = "R:";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(357, 147);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(151, 45);
            this.delete_button.TabIndex = 33;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // figuresListBox
            // 
            this.figuresListBox.FormattingEnabled = true;
            this.figuresListBox.ItemHeight = 16;
            this.figuresListBox.Location = new System.Drawing.Point(143, 12);
            this.figuresListBox.Name = "figuresListBox";
            this.figuresListBox.Size = new System.Drawing.Size(203, 196);
            this.figuresListBox.TabIndex = 34;
            // 
            // move_button
            // 
            this.move_button.Location = new System.Drawing.Point(357, 97);
            this.move_button.Name = "move_button";
            this.move_button.Size = new System.Drawing.Size(151, 45);
            this.move_button.TabIndex = 35;
            this.move_button.Text = "move";
            this.move_button.UseVisualStyleBackColor = true;
            this.move_button.Click += new System.EventHandler(this.move_button_Click);
            // 
            // move_x
            // 
            this.move_x.Location = new System.Drawing.Point(387, 38);
            this.move_x.Name = "move_x";
            this.move_x.Size = new System.Drawing.Size(121, 22);
            this.move_x.TabIndex = 36;
            // 
            // move_y
            // 
            this.move_y.Location = new System.Drawing.Point(388, 68);
            this.move_y.Name = "move_y";
            this.move_y.Size = new System.Drawing.Size(120, 22);
            this.move_y.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(352, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 25);
            this.label15.TabIndex = 38;
            this.label15.Text = "X:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(352, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 25);
            this.label16.TabIndex = 39;
            this.label16.Text = "Y:";
            // 
            // c_rect_button
            // 
            this.c_rect_button.Location = new System.Drawing.Point(6, 30);
            this.c_rect_button.Name = "c_rect_button";
            this.c_rect_button.Size = new System.Drawing.Size(120, 40);
            this.c_rect_button.TabIndex = 40;
            this.c_rect_button.Text = "change rectangle";
            this.c_rect_button.UseVisualStyleBackColor = true;
            this.c_rect_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // c_sq_button
            // 
            this.c_sq_button.Location = new System.Drawing.Point(6, 76);
            this.c_sq_button.Name = "c_sq_button";
            this.c_sq_button.Size = new System.Drawing.Size(120, 40);
            this.c_sq_button.TabIndex = 41;
            this.c_sq_button.Text = "change square";
            this.c_sq_button.UseVisualStyleBackColor = true;
            this.c_sq_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // c_ellipse_button
            // 
            this.c_ellipse_button.Location = new System.Drawing.Point(6, 122);
            this.c_ellipse_button.Name = "c_ellipse_button";
            this.c_ellipse_button.Size = new System.Drawing.Size(120, 40);
            this.c_ellipse_button.TabIndex = 42;
            this.c_ellipse_button.Text = "change ellipse";
            this.c_ellipse_button.UseVisualStyleBackColor = true;
            this.c_ellipse_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // c_circle_button
            // 
            this.c_circle_button.Location = new System.Drawing.Point(6, 168);
            this.c_circle_button.Name = "c_circle_button";
            this.c_circle_button.Size = new System.Drawing.Size(120, 40);
            this.c_circle_button.TabIndex = 43;
            this.c_circle_button.Text = "change circle";
            this.c_circle_button.UseVisualStyleBackColor = true;
            this.c_circle_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // Polygon_create
            // 
            this.Polygon_create.Location = new System.Drawing.Point(679, 246);
            this.Polygon_create.Name = "Polygon_create";
            this.Polygon_create.Size = new System.Drawing.Size(130, 45);
            this.Polygon_create.TabIndex = 44;
            this.Polygon_create.Text = "create polygon";
            this.Polygon_create.UseVisualStyleBackColor = true;
            this.Polygon_create.Click += new System.EventHandler(this.Polygon_create_Click);
            // 
            // Triangle_create
            // 
            this.Triangle_create.Location = new System.Drawing.Point(679, 195);
            this.Triangle_create.Name = "Triangle_create";
            this.Triangle_create.Size = new System.Drawing.Size(130, 45);
            this.Triangle_create.TabIndex = 45;
            this.Triangle_create.Text = "create triangle";
            this.Triangle_create.UseVisualStyleBackColor = true;
            this.Triangle_create.Click += new System.EventHandler(this.Triangle_create_Click);
            // 
            // Cat_create
            // 
            this.Cat_create.Location = new System.Drawing.Point(833, 170);
            this.Cat_create.Name = "Cat_create";
            this.Cat_create.Size = new System.Drawing.Size(130, 45);
            this.Cat_create.TabIndex = 46;
            this.Cat_create.Text = "create cat";
            this.Cat_create.UseVisualStyleBackColor = true;
            this.Cat_create.Click += new System.EventHandler(this.Car_create_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(830, 243);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 25);
            this.label17.TabIndex = 50;
            this.label17.Text = "Y:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(828, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 25);
            this.label18.TabIndex = 49;
            this.label18.Text = "X:";
            // 
            // cat_y
            // 
            this.cat_y.Location = new System.Drawing.Point(867, 246);
            this.cat_y.Name = "cat_y";
            this.cat_y.Size = new System.Drawing.Size(96, 22);
            this.cat_y.TabIndex = 48;
            // 
            // cat_x
            // 
            this.cat_x.Location = new System.Drawing.Point(867, 218);
            this.cat_x.Name = "cat_x";
            this.cat_x.Size = new System.Drawing.Size(96, 22);
            this.cat_x.TabIndex = 47;
            // 
            // Change
            // 
            this.Change.Controls.Add(this.c_rect_button);
            this.Change.Controls.Add(this.c_sq_button);
            this.Change.Controls.Add(this.c_ellipse_button);
            this.Change.Controls.Add(this.c_circle_button);
            this.Change.Controls.Add(this.figuresListBox);
            this.Change.Controls.Add(this.delete_button);
            this.Change.Controls.Add(this.move_y);
            this.Change.Controls.Add(this.move_button);
            this.Change.Controls.Add(this.label16);
            this.Change.Controls.Add(this.move_x);
            this.Change.Controls.Add(this.label15);
            this.Change.Location = new System.Drawing.Point(718, 330);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(512, 214);
            this.Change.TabIndex = 51;
            this.Change.TabStop = false;
            this.Change.Text = "Change";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(995, 302);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 25);
            this.label19.TabIndex = 60;
            this.label19.Text = "H:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(995, 274);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 25);
            this.label20.TabIndex = 59;
            this.label20.Text = "W:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(995, 246);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 25);
            this.label21.TabIndex = 58;
            this.label21.Text = "Y:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(995, 218);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 25);
            this.label22.TabIndex = 57;
            this.label22.Text = "X:";
            // 
            // star_h
            // 
            this.star_h.Location = new System.Drawing.Point(1033, 302);
            this.star_h.Name = "star_h";
            this.star_h.Size = new System.Drawing.Size(91, 22);
            this.star_h.TabIndex = 56;
            this.star_h.Text = "50";
            // 
            // star_w
            // 
            this.star_w.Location = new System.Drawing.Point(1033, 274);
            this.star_w.Name = "star_w";
            this.star_w.Size = new System.Drawing.Size(91, 22);
            this.star_w.TabIndex = 55;
            this.star_w.Text = "50";
            // 
            // star_y
            // 
            this.star_y.Location = new System.Drawing.Point(1033, 246);
            this.star_y.Name = "star_y";
            this.star_y.Size = new System.Drawing.Size(91, 22);
            this.star_y.TabIndex = 54;
            // 
            // star_x
            // 
            this.star_x.Location = new System.Drawing.Point(1033, 218);
            this.star_x.Name = "star_x";
            this.star_x.Size = new System.Drawing.Size(91, 22);
            this.star_x.TabIndex = 53;
            // 
            // Star_create
            // 
            this.Star_create.Location = new System.Drawing.Point(994, 170);
            this.Star_create.Name = "Star_create";
            this.Star_create.Size = new System.Drawing.Size(130, 45);
            this.Star_create.TabIndex = 52;
            this.Star_create.Text = "create star";
            this.Star_create.UseVisualStyleBackColor = true;
            this.Star_create.Click += new System.EventHandler(this.Star_create_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(1144, 302);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 25);
            this.label23.TabIndex = 69;
            this.label23.Text = "H:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(1144, 274);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 25);
            this.label24.TabIndex = 68;
            this.label24.Text = "W:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(1144, 246);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(31, 25);
            this.label25.TabIndex = 67;
            this.label25.Text = "Y:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(1144, 218);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(32, 25);
            this.label26.TabIndex = 66;
            this.label26.Text = "X:";
            // 
            // olymp_h
            // 
            this.olymp_h.Location = new System.Drawing.Point(1182, 302);
            this.olymp_h.Name = "olymp_h";
            this.olymp_h.Size = new System.Drawing.Size(91, 22);
            this.olymp_h.TabIndex = 65;
            this.olymp_h.Text = "100";
            // 
            // olymp_w
            // 
            this.olymp_w.Location = new System.Drawing.Point(1182, 274);
            this.olymp_w.Name = "olymp_w";
            this.olymp_w.Size = new System.Drawing.Size(91, 22);
            this.olymp_w.TabIndex = 64;
            this.olymp_w.Text = "140";
            // 
            // olymp_y
            // 
            this.olymp_y.Location = new System.Drawing.Point(1182, 246);
            this.olymp_y.Name = "olymp_y";
            this.olymp_y.Size = new System.Drawing.Size(91, 22);
            this.olymp_y.TabIndex = 63;
            // 
            // olymp_x
            // 
            this.olymp_x.Location = new System.Drawing.Point(1182, 218);
            this.olymp_x.Name = "olymp_x";
            this.olymp_x.Size = new System.Drawing.Size(91, 22);
            this.olymp_x.TabIndex = 62;
            // 
            // Olymp_create
            // 
            this.Olymp_create.Location = new System.Drawing.Point(1143, 170);
            this.Olymp_create.Name = "Olymp_create";
            this.Olymp_create.Size = new System.Drawing.Size(130, 45);
            this.Olymp_create.TabIndex = 61;
            this.Olymp_create.Text = "create olymp";
            this.Olymp_create.UseVisualStyleBackColor = true;
            this.Olymp_create.Click += new System.EventHandler(this.Olymp_create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 552);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.olymp_h);
            this.Controls.Add(this.olymp_w);
            this.Controls.Add(this.olymp_y);
            this.Controls.Add(this.olymp_x);
            this.Controls.Add(this.Olymp_create);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.star_h);
            this.Controls.Add(this.star_w);
            this.Controls.Add(this.star_y);
            this.Controls.Add(this.star_x);
            this.Controls.Add(this.Star_create);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cat_y);
            this.Controls.Add(this.cat_x);
            this.Controls.Add(this.Cat_create);
            this.Controls.Add(this.Triangle_create);
            this.Controls.Add(this.Polygon_create);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circ_r);
            this.Controls.Add(this.circ_y);
            this.Controls.Add(this.circ_x);
            this.Controls.Add(this.el_r2);
            this.Controls.Add(this.el_r1);
            this.Controls.Add(this.el_y);
            this.Controls.Add(this.el_x);
            this.Controls.Add(this.sq_w);
            this.Controls.Add(this.sq_y);
            this.Controls.Add(this.sq_x);
            this.Controls.Add(this.rect_h);
            this.Controls.Add(this.rect_w);
            this.Controls.Add(this.rect_y);
            this.Controls.Add(this.rect_x);
            this.Controls.Add(this.Circle_create);
            this.Controls.Add(this.El_create);
            this.Controls.Add(this.Sq_create);
            this.Controls.Add(this.Rect_create);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Lab5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Change.ResumeLayout(false);
            this.Change.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Rect_create;
        private System.Windows.Forms.Button Sq_create;
        private System.Windows.Forms.Button El_create;
        private System.Windows.Forms.Button Circle_create;
        private System.Windows.Forms.TextBox rect_x;
        private System.Windows.Forms.TextBox rect_y;
        private System.Windows.Forms.TextBox rect_w;
        private System.Windows.Forms.TextBox rect_h;
        private System.Windows.Forms.TextBox sq_x;
        private System.Windows.Forms.TextBox sq_y;
        private System.Windows.Forms.TextBox sq_w;
        private System.Windows.Forms.TextBox el_x;
        private System.Windows.Forms.TextBox el_y;
        private System.Windows.Forms.TextBox el_r1;
        private System.Windows.Forms.TextBox el_r2;
        private System.Windows.Forms.TextBox circ_x;
        private System.Windows.Forms.TextBox circ_y;
        private System.Windows.Forms.TextBox circ_r;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.ListBox figuresListBox;
        private System.Windows.Forms.Button move_button;
        private System.Windows.Forms.TextBox move_x;
        private System.Windows.Forms.TextBox move_y;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button c_rect_button;
        private System.Windows.Forms.Button c_sq_button;
        private System.Windows.Forms.Button c_ellipse_button;
        private System.Windows.Forms.Button c_circle_button;
        private System.Windows.Forms.Button Polygon_create;
        private System.Windows.Forms.Button Triangle_create;
        private System.Windows.Forms.Button Cat_create;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox cat_y;
        private System.Windows.Forms.TextBox cat_x;
        private System.Windows.Forms.GroupBox Change;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox star_h;
        private System.Windows.Forms.TextBox star_w;
        private System.Windows.Forms.TextBox star_y;
        private System.Windows.Forms.TextBox star_x;
        private System.Windows.Forms.Button Star_create;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox olymp_h;
        private System.Windows.Forms.TextBox olymp_w;
        private System.Windows.Forms.TextBox olymp_y;
        private System.Windows.Forms.TextBox olymp_x;
        private System.Windows.Forms.Button Olymp_create;
    }
}

